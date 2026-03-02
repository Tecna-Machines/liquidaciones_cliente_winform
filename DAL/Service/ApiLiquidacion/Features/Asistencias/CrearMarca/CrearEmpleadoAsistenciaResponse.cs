namespace DAL.Service.ApiLiquidacion.Features.Asistencias.CrearMarca
{
    public record CrearEmpleadoAsistenciaRequest(string Dni,
                                                 DateTime Entrada,
                                                 DateTime Salida) :
                                                 CrearEmpleadoAsistenciaResponse(Dni, Entrada, Salida);
    public record CrearEmpleadoAsistenciaResponse(string Dni,
                                                  DateTime Entrada,
                                                  DateTime Salida);

}
