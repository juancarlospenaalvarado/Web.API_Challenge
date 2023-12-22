namespace Application.Permisos.Create;

public record CreatePermisoCommand(
    string NombreEmpleado,
    string ApellidoEmpleado,
    string TipoPermiso,
    DateTime FechaPermiso) : IRequest<ErrorOr<int>>;
