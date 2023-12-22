using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Permisos.Create;

public class CreatePermisoCommandValidator : AbstractValidator<CreatePermisoCommand>
{

    public CreatePermisoCommandValidator() {
        RuleFor(r => r.NombreEmpleado)
                .NotEmpty()
                .MaximumLength(50);
    }
}
