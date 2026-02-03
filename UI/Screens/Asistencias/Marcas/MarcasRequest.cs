namespace UI.Screens.Asistencias.Marcas
{
    public sealed record MarcasRequest(string DniEmpleado,
                                       int Quicena,
                                       int Mes,
                                       int Anio);
}
