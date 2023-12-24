namespace Application.Permisos.Update;

public record UpdatePermisoCommand(
    int Id,
    string NombreEmpleado,
    string ApellidoEmpleado,
    int TipoPermiso,
    DateTime FechaPermiso) : IRequest<ErrorOr<Unit>>;
