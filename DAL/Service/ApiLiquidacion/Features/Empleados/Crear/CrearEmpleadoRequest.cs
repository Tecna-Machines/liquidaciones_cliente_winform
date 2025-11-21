namespace DAL.Service.Liquidacion.UseCase.Empleados.Crear
{
    public record CrearEmpleadoRequest(string Dni,
                                       string Nombre,
                                       string Apellido,
                                       DateTime FechaIngreso,
                                       DateTime FechaNacimiento,
                                       DateTime FechaAlta);

    public record CrearEmpleadoResponse(string Dni,
                                          string Nombre,
                                          string Apellido);


}
