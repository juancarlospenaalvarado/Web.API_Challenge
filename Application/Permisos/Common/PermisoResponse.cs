using Domain.Entities.Permisos;

namespace Application.Permisos.Common;

public record PermisoResponse(
int Id,
string NombreEmpleado,
string ApellidoEmpleado,
TipoPermisos TipoPermiso,
DateTime FechaPermiso);
