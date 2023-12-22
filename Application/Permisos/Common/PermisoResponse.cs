namespace Application.Permisos.Common;

public record PermisoResponse(
int Id,
string NombreEmpleado,
string ApellidoEmpleado,
string TipoPermiso,
DateTime FechaPermiso);
