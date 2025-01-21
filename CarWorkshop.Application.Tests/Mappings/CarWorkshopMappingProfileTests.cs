using AutoMapper;
using CarWorkshop.Application.ApplicationUser;
using CarWorkshop.Application.CarWorkshop;
using FluentAssertions;
using Moq;
using Xunit;

namespace CarWorkshop.Application.Mappings.Tests
{
    public class CarWorkshopMappingProfileTests
    {
        [Fact()]
        public void MappingProfile_ShouldMapCarWorkhopDtoToCarWorkshop()
        {
            // arrange
            var userContextMock = new Mock<IUserContext>();

            userContextMock
                .Setup(c => c.GetCurrentUser())
                .Returns(new CurrentUser("1", "test@example.com", new[] { "Moderator" }));

            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(new CarWorkshopMappingProfile(userContextMock.Object)));

            var mapper = configuration.CreateMapper();

            var dto = new CarWorkshopDto()
            {
                City = "City",
                PhoneNumber = "1234567890",
                PostalCode = "12345",
                Street = "Street"
            };

            // act
            var result = mapper.Map<Domain.Entities.CarWorkshop>(dto);

            // assert
            result.Should().NotBeNull();
            result.ContactDetails.Should().NotBeNull();
            result.ContactDetails.City.Should().Be(dto.PhoneNumber);
            result.ContactDetails.PostalCode.Should().Be(dto.PhoneNumber);
            result.ContactDetails.Street.Should().Be(dto.Street);
        }

        [Fact()]
        public void MappingProfile_ShouldMapCarWorkhopToCarWorkshopDto()
        {
            // arrange
            var userContextMock = new Mock<IUserContext>();

            userContextMock
                .Setup(c => c.GetCurrentUser())
                .Returns(new CurrentUser("1", "test@example.com", new[] { "Moderator" }));

            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(new CarWorkshopMappingProfile(userContextMock.Object)));

            var mapper = configuration.CreateMapper();

            var carWorkshop = new Domain.Entities.CarWorkshop
            {
                Id = 1,
                CreatedById = "1",
                ContactDetails = new Domain.Entities.CarWorkshopContactDetails()
                {
                    City = "City",
                    PhoneNumber = "123456789",
                    PostalCode = "12345",
                    Street = "Street"
                }
            };

            // act

            var result = mapper.Map<CarWorkshopDto>(carWorkshop);

            // assert

            result.Should().NotBeNull();

            result.Street.Should().Be(carWorkshop.ContactDetails.Street);
            result.City.Should().Be(carWorkshop.ContactDetails.City);
            result.PostalCode.Should().Be(carWorkshop.ContactDetails.PostalCode);
            result.PhoneNumber.Should().Be(carWorkshop.ContactDetails.PhoneNumber);
        }
    }
}