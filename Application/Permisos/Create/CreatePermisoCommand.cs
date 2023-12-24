using Domain.Entities.Permisos;

namespace Application.Permisos.Create;

public record CreatePermisoCommand(
    string NombreEmpleado,
    string ApellidoEmpleado,
    int TipoPermiso,
    DateTime FechaPermiso) : IRequest<ErrorOr<int>>;
