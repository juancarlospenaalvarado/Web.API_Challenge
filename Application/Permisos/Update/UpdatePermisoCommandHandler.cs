using Domain.Entities.Permisos;
using Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Application.Permisos.Update
{
    internal sealed class UpdatePermisoCommandHandler :IRequestHandler<UpdatePermisoCommand,ErrorOr<Unit>>
    {
        private readonly IPermisoRepository _permisoRepository;
        private readonly IUnitOfWork _unitOfWork;
  
        public UpdatePermisoCommandHandler(IPermisoRepository permisoRepository, IUnitOfWork unitOfWork)
        {
            _permisoRepository = permisoRepository ?? throw new ArgumentNullException(nameof(permisoRepository));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }
        public async Task<ErrorOr<Unit>> Handle(UpdatePermisoCommand command, CancellationToken cancellationToken)
        {
            if (!await _permisoRepository.ExistsAsync((command.Id)))
            {
                return Error.NotFound("Customer.NotFound", "The customer with the provide Id was not found.");
            }

            Permiso permiso = Permiso.UpdatPermiso(
                command.Id, 
                command.NombreEmpleado,
                command.ApellidoEmpleado,
                command.TipoPermiso,
                command.FechaPermiso);

            _permisoRepository.Update(permiso);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
