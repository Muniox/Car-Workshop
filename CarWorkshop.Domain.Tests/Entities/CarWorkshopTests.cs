using FluentAssertions;
using Xunit;

namespace CarWorkshop.Domain.Entities.Tests
{
    public class CarWorkshopTests
    {
        [Fact()]
        public void EncodeName_ShouldSetEncodedName()
        {
            // arrange
            var carWorkshop = new CarWorkshop();
            carWorkshop.Name = "Test Workshop";

            // act
            carWorkshop.EncodeName();

            // assert
            carWorkshop.EncodedName.Should().Be("test-workshop"); // fluent assertion jest płatne teraz XDD należy używać wersji 7 https://www.youtube.com/watch?v=ZFc6jcaM6Ms&t=300s
            //Xunit.Assert.Equivalent(carWorkshop.EncodedName, "test-workshop"); // albo nie używać
        }

        [Fact()]
        public void EndodeName_ShouldThrowException_WhenNameIsNull()
        {
            // arrange
            var carWorkshop = new CarWorkshop();

            // act
            Action action = () => carWorkshop.EncodeName();

            // arrange
            action.Invoking(a => a.Invoke()).Should().Throw<NullReferenceException>();
        }
    }
}