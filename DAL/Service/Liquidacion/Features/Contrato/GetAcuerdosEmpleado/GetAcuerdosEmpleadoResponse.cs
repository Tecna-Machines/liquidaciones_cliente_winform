namespace DAL.Service.Liquidacion.Features.Contrato.GetAcuerdosEmpleado
{

    public sealed record GetAcuerdosEmpleadosResponse(string Dni,
                                                      string Nombre,
                                                      string Apellido,
                                                      IEnumerable<GetAcuerdoEmpleado> Historial);

    public sealed record GetAcuerdoEmpleado(string Codigo,
                                            DateTime Fecha,
                                            decimal ValorHora,
                                            decimal ValorBlanco,
                                            decimal Sueldo,
                                            int TipoSueldo,
                                            string Notas);
}
