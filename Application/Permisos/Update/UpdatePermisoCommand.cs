namespace Application.Permisos.Update;

public record UpdatePermisoCommand(
    int Id,
    string NombreEmpleado,
    string ApellidoEmpleado,
    string TipoPermiso,
    DateTime FechaPermiso) : IRequest<ErrorOr<Unit>>;
