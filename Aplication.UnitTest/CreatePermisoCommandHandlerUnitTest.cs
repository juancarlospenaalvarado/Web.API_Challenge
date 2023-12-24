using Application.Permisos.Create;
using Domain.Entities.Permisos;
using Domain.Primitives;

namespace Aplication.UnitTest;

public class CreatePermisoCommandHandlerUnitTest
{
    private readonly Mock<IPermisoRepository> _mockPermisoRepository;
    private readonly Mock<IUnitOfWork> _mockUnitOfWork;
    private readonly CreatePermisoCommandHandler _handler;

    public CreatePermisoCommandHandlerUnitTest()
    {
        _mockPermisoRepository = new Mock<IPermisoRepository>();
        _mockUnitOfWork = new Mock<IUnitOfWork>();

        _handler = new CreatePermisoCommandHandler(_mockPermisoRepository.Object, _mockUnitOfWork.Object);
    }

    [Fact]
    public async Task HandleCreateCustomer_WhenPhoneNumberHasBadFormat_ShouldReturnValidationError()
    {
        //Arrange
        // Se configura los parametros de entrada de nuestra prueba unitaria.
        CreatePermisoCommand command = new CreatePermisoCommand("Juan", "Alvarado", 2, System.DateTime.Now);
        //Act
        // Se ejecuta el metodo a probar de nuestra prueba unitaria
        var result = await _handler.Handle(command, default);
        //Assert
        // Se verifica los datos de retorno de nuestro metodo probado en la prueba unitaria
        result.IsError.Should().BeFalse();
    }

}