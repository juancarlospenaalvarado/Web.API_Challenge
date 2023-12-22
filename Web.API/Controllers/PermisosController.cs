using Application.Permisos.Create;
using Application.Permisos.GetAll;
using Application.Permisos.GetById;
using Application.Permisos.Update;

namespace Web.API.Controllers;


[Route("permisos")]
public class Permisos: ApiController
{



    private readonly ISender _mediator;

    public Permisos(ISender mediator)
    {
        _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
    }
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var permisosResult = await _mediator.Send(new GetAllPermisosQuery());

        return permisosResult.Match(
            permisos => Ok(permisos),
            errors => Problem(errors)
        );
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var customerResult = await _mediator.Send(new GetPermisoByIdQuery(id));

        return customerResult.Match(
            customer => Ok(customer),
            errors => Problem(errors)
        );
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreatePermisoCommand command)
    {
        var createResult = await _mediator.Send(command);

        return createResult.Match(
            permisoId => Ok(permisoId),
            errors => Problem(errors)
        );
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] UpdatePermisoCommand command)
    {
        if (command.Id != id)
        {
            List<Error> errors = new()
            {
                Error.Validation("Customer.UpdateInvalid", "The request Id does not match with the url Id.")
            };
            return Problem(errors);
        }

        var updateResult = await _mediator.Send(command);

        return updateResult.Match(
            customerId => NoContent(),
            errors => Problem(errors)
        );
    }

    //[HttpDelete("{id}")]
    //public async Task<IActionResult> Delete(Guid id)
    //{
    //    var deleteResult = await _mediator.Send(new DeleteCustomerCommand(id));

    //    return deleteResult.Match(
    //        customerId => NoContent(),
    //        errors => Problem(errors)
    //    );
    //}
}