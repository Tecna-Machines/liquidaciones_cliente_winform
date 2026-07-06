#define MyAppName "AkerLQ"

#ifndef MyAppVersion
  #define MyAppVersion "v1"
#endif

#ifndef PublishDir
  #define PublishDir "D:\dev\sources\laucha-desktopApp\UI\bin\Release\net8.0-windows\publish"
#endif

#ifndef MyAppPublisher
  #define MyAppPublisher "Gabyx 708"
#endif

#define MyAppExeName "Liquidaciones.exe"

[Setup]
AppId={{76E59E32-F2B7-4B8C-ACB6-55078C390F70}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
VersionInfoCompany={#MyAppPublisher}
VersionInfoCopyright=Gabyx 708
DefaultDirName={autopf}\{#MyAppName}
UninstallDisplayIcon={app}\{#MyAppExeName}
ArchitecturesAllowed=x64compatible
ArchitecturesInstallIn64BitMode=x64compatible
DisableProgramGroupPage=yes
PrivilegesRequiredOverridesAllowed=dialog
OutputBaseFilename=AkerLQ-Cliente-instalador-{#MyAppVersion}
SolidCompression=yes
WizardStyle=modern dynamic

[Languages]
Name: "spanish"; MessagesFile: "compiler:Languages\Spanish.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "{#PublishDir}\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "Ejecutar {#MyAppName}"; Flags: nowait postinstall skipifsilent