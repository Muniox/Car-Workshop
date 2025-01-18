using FluentValidation.TestHelper;
using Xunit;

namespace CarWorkshop.Application.CarWorkshopService.Commands.Tests
{
    public class CreateCarWorkshopServiceCommandValidatorTests
    {
        [Fact()]
        public void Validate_WithCommand_ShouldNotHaveValidationErrors()
        {
            // arrange

            var validator = new CreateCarWorkshopServiceCommandValidator();
            var command = new CreateCarWorkshopServiceCommand()
            {
                Cost = "100 PLN",
                Description = "Description",
                CarWorkshopEndodedName = "Workshop1"
            };

            // act

            var result = validator.TestValidate(command);

            // assert

            result.ShouldNotHaveAnyValidationErrors();
        }

        [Fact()]
        public void Validate_WithInvalidCommand_ShouldHaveValidationErrors()
        {
            // arrange

            var validator = new CreateCarWorkshopServiceCommandValidator();
            var command = new CreateCarWorkshopServiceCommand()
            {
                Cost = "",
                Description = "",
                CarWorkshopEndodedName = null
            };

            // act

            var result = validator.TestValidate(command);

            // assert

            result.ShouldHaveValidationErrorFor(c => c.Cost);
            result.ShouldHaveValidationErrorFor(c => c.Description);
            result.ShouldHaveValidationErrorFor(c => c.CarWorkshopEndodedName);
        }
    }
}