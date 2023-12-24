using Application.Permisos.Common;
using Domain.Entities.Permisos;

namespace Application.Permisos.GetById;

internal sealed class GetPermisoByIdQueryHandler : IRequestHandler<GetPermisoByIdQuery, ErrorOr<PermisoResponse>>
{

    
    private readonly IPermisoRepository _permisoRepository;

    public GetPermisoByIdQueryHandler(IPermisoRepository permisoRepository)
    {
        _permisoRepository = permisoRepository ?? throw new ArgumentNullException(nameof(permisoRepository));
    }

     public async Task<ErrorOr<PermisoResponse>> Handle(GetPermisoByIdQuery query, CancellationToken cancellationToken)
    {
        if (await _permisoRepository.GetByIdAsync((query.Id)) is not Permiso permiso)
        {
            return Error.NotFound("Permiso.NotFound", "The customer with the provide Id was not found.");
        }

        return new PermisoResponse(
            permiso.Id,
            permiso.NombreEmpleado,
            permiso.ApellidoEmpleado,
            permiso.TipoPermisos,
            permiso.FechaPermiso);
    }
}
