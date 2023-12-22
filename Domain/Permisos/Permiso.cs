using Domain.Primitives;

namespace Domain.Permisos;

public sealed class Permiso : AggregateRoot
{
    public Permiso(int id, string nombreEmpleado, string apellidoEmpleado, string tipoPermiso,  DateTime fechaPermiso)
    {
        Id = id;
        NombreEmpleado = nombreEmpleado;
        ApellidoEmpleado = apellidoEmpleado;
        TipoPermiso = tipoPermiso;
        FechaPermiso = fechaPermiso;
    }
    public Permiso( string nombreEmpleado, string apellidoEmpleado, string tipoPermiso, DateTime fechaPermiso)
    {
        NombreEmpleado = nombreEmpleado;
        ApellidoEmpleado = apellidoEmpleado;
        TipoPermiso = tipoPermiso;
        FechaPermiso = fechaPermiso;
    }

    private Permiso()
    {
    }

    public int Id { get;  init; }
    public string NombreEmpleado { get; set; } = string.Empty;
    public string ApellidoEmpleado { get; set; } = string.Empty;
    public string TipoPermiso { get; set; } = string.Empty;
    public DateTime FechaPermiso { get; set; }

    public static Permiso UpdatPermiso(int id, string NombreEmpleado, string ApellidoEmpleado, string TipoPermiso,DateTime fechaPermiso)
    {
        return new Permiso(id, NombreEmpleado, ApellidoEmpleado, TipoPermiso, fechaPermiso);
    }
}
