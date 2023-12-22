using Application.Permisos.Common;
using Domain.Permisos;

namespace Application.Permisos.GetAll;

internal sealed class GetAllPermisosQueryHandler : IRequestHandler<GetAllPermisosQuery, ErrorOr<IReadOnlyList<PermisoResponse>>>
{
    private readonly IPermisoRepository _permisoRepository;

    public GetAllPermisosQueryHandler(IPermisoRepository permisoRepository)
    {
        _permisoRepository = permisoRepository ?? throw new ArgumentNullException(nameof(permisoRepository));
    }

    public async Task<ErrorOr<IReadOnlyList<PermisoResponse>>> Handle(GetAllPermisosQuery query, CancellationToken cancellationToken)
    {
        IReadOnlyList<Permiso> permisos = await _permisoRepository.GetAll();

        return permisos.Select(permiso => new PermisoResponse(
                permiso.Id,
                permiso.NombreEmpleado,
                permiso.ApellidoEmpleado,
                permiso.TipoPermiso,
                permiso.FechaPermiso
            )).ToList();
    }
}