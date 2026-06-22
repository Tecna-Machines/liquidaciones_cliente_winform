namespace DAL.Service.ApiLiquidacion.Features.Asistencias.GetAsistenciaByEmpleado
{
    public record GetEmpleadoAsistenciaRequest(string Dni, DateTime Inicio, DateTime Fin);
    public record GetEmpleadoAsistenciasResponse(string Dni,
                                                 string NombreApellido,
                                                 IEnumerable<GetEmpleadoAsistenciaResponse> Asistencias);

    public record GetEmpleadoAsistenciaResponse(DateTime Ingreso,
                                                DateTime Egreso,
                                                TimeSpan DebeEntrar,
                                                string Observacion,
                                                decimal HsExtra,
                                                decimal HsComunes,
                                                decimal HsDoble,
                                                decimal HsTotales);
}
