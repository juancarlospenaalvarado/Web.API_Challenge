using Domain.Entities.Permisos;
using Domain.Primitives;

namespace Application.Permisos.Create;

public sealed class CreatePermisoCommandHandler : IRequestHandler<CreatePermisoCommand, ErrorOr<int>>
{
    private readonly IPermisoRepository _permisoRepository;
    private readonly IUnitOfWork _unitOfWork;
    public CreatePermisoCommandHandler(IPermisoRepository customerRepository, IUnitOfWork unitOfWork)
    {
        _permisoRepository = customerRepository ?? throw new ArgumentNullException(nameof(customerRepository));
        _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
    }
    public async Task<ErrorOr<int>> Handle(CreatePermisoCommand command, CancellationToken cancellationToken)
    {

        var permiso = new Permiso(
            command.NombreEmpleado,
            command.ApellidoEmpleado,
            command.TipoPermiso,
            command.FechaPermiso
        );

        _permisoRepository.Add(permiso);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return permiso.Id;
    }
}
