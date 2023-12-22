using Application.Permisos.Common;

namespace Application.Permisos.GetById;

public record GetPermisoByIdQuery(int Id) : IRequest<ErrorOr<PermisoResponse>>;
