using Domain.Primitives;

namespace Domain.Entities.Permisos;

public sealed class Permiso : AggregateRoot
{
    public Permiso(int id, string nombreEmpleado, string apellidoEmpleado, int tipoPermiso, DateTime fechaPermiso)
    {
        Id = id;
        NombreEmpleado = nombreEmpleado;
        ApellidoEmpleado = apellidoEmpleado;
        TipoPermisosId = tipoPermiso;
        FechaPermiso = fechaPermiso;
    }
    public Permiso(string nombreEmpleado, string apellidoEmpleado, int tipoPermiso, DateTime fechaPermiso)
    {
        NombreEmpleado = nombreEmpleado;
        ApellidoEmpleado = apellidoEmpleado;
        TipoPermisosId = tipoPermiso;
        FechaPermiso = fechaPermiso;
    }

    private Permiso()
    {
    }

    public int Id { get; init; }
    public string NombreEmpleado { get; set; } = string.Empty;
    public string ApellidoEmpleado { get; set; } = string.Empty;
    public int TipoPermisosId { get; set; }
    public TipoPermisos TipoPermisos { get; set; }
    public DateTime FechaPermiso { get; set; }

    public static Permiso UpdatPermiso(int id, string NombreEmpleado, string ApellidoEmpleado, int TipoPermiso, DateTime fechaPermiso)
    {
        return new Permiso(id, NombreEmpleado, ApellidoEmpleado, TipoPermiso, fechaPermiso);
    }
}
