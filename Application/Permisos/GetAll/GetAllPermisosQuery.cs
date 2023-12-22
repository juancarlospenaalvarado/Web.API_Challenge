using Application.Permisos.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Permisos.GetAll;

public record GetAllPermisosQuery() : IRequest<ErrorOr<IReadOnlyList<PermisoResponse>>>;
