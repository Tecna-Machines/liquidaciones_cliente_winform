$ErrorActionPreference = "Stop"

$RootDir = Split-Path -Parent $MyInvocation.MyCommand.Path

$ProjectDir = Join-Path $RootDir "UI"
$ProjectFile = Join-Path $ProjectDir "UI.csproj"
$InstallerDir = Join-Path $RootDir "installer"
$IssFile = Join-Path $InstallerDir "AkerLQ-installer.iss"

$PublishDir = Join-Path $ProjectDir "bin\Release\publish"

$InnoCompiler = "C:\Program Files (x86)\Inno Setup 6\ISCC.exe"

Write-Host ""
Write-Host "=== Build instalador AkerLQ Cliente ==="
Write-Host ""

$Version = Read-Host "Ingrese version del cliente. Ejemplo: v3"
$Server = Read-Host "Ingrese servidor API. Ejemplo: https://localhost:7033/api/v1/"
$OutputDir = Read-Host "Ingrese carpeta destino del instalador. Ejemplo: D:\Instaladores"

if (-not (Test-Path $InnoCompiler)) {
    throw "No se encontro Inno Setup Compiler en: $InnoCompiler"
}

if (-not (Test-Path $ProjectFile)) {
    throw "No se encontro el proyecto: $ProjectFile"
}

if (-not (Test-Path $IssFile)) {
    throw "No se encontro el archivo .iss: $IssFile"
}

if (-not (Test-Path $OutputDir)) {
    New-Item -ItemType Directory -Path $OutputDir | Out-Null
}

$InstallerBaseName = "AkerLQ-Cliente-instalador-$Version"
$ExePath = Join-Path $OutputDir "$InstallerBaseName.exe"
$ZipPath = Join-Path $OutputDir "$InstallerBaseName.zip"

Write-Host ""
Write-Host "Limpiando publish anterior..."
Remove-Item $PublishDir -Recurse -Force -ErrorAction SilentlyContinue

Write-Host "Publicando aplicacion..."
dotnet publish $ProjectFile `
    -c Release `
    -r win-x64 `
    --self-contained true `
    -p:PublishSingleFile=false `
    -o $PublishDir

Write-Host "Buscando archivo .config publicado..."

$ConfigFiles = Get-ChildItem $PublishDir -Filter "*.config" -File

$ConfigPath = $ConfigFiles |
    Where-Object {
        $content = Get-Content $_.FullName -Raw
        $content -like '*key="server"*' -and $content -like '*key="client_version"*'
    } |
    Select-Object -First 1 -ExpandProperty FullName

if (-not $ConfigPath) {
    throw "No se encontro un archivo .config con las claves server y client_version en: $PublishDir"
}

Write-Host "Modificando app.config publicado:"
Write-Host $ConfigPath

[xml]$ConfigXml = Get-Content $ConfigPath

foreach ($add in $ConfigXml.configuration.appSettings.add) {
    if ($add.key -eq "server") {
        $add.SetAttribute("value", $Server)
    }

    if ($add.key -eq "client_version") {
        $add.SetAttribute("value", $Version)
    }
}

$ConfigXml.Save($ConfigPath)

Write-Host "Compilando instalador con Inno Setup..."

& $InnoCompiler `
    /DMyAppVersion="$Version" `
    /DPublishDir="$PublishDir" `
    /O"$OutputDir" `
    /F"$InstallerBaseName" `
    "$IssFile"

if (-not (Test-Path $ExePath)) {
    throw "No se genero el instalador esperado: $ExePath"
}

Write-Host "Generando ZIP..."

if (Test-Path $ZipPath) {
    Remove-Item $ZipPath -Force
}

Compress-Archive -Path $ExePath -DestinationPath $ZipPath -Force

Write-Host ""
Write-Host "Proceso terminado correctamente."
Write-Host "Instalador:"
Write-Host $ExePath
Write-Host ""
Write-Host "ZIP:"
Write-Host $ZipPath
Write-Host ""
Pause