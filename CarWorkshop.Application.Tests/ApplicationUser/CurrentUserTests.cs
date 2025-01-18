using FluentAssertions;
using Xunit;

namespace CarWorkshop.Application.ApplicationUser.Tests
{
    public class CurrentUserTests
    {
        [Fact()]
        public void IsInARole_WithMatchingRole_ShouldReturnTrue()
        {
            // arrange

            var currentUser = new CurrentUser("1", "test@tests.com", new List<string> { "Admin", "User" });

            // act

            var isAInRole = currentUser.IsAInRole("Admin");

            // assert

            isAInRole.Should().BeTrue();
        }

        [Fact()]
        public void IsInARole_WithMatchingRole_ShouldReturnFalse()
        {
            // arrange

            var currentUser = new CurrentUser("1", "test@tests.com", new List<string> { "Admin", "User" });

            // act

            var isAInRole = currentUser.IsAInRole("Manager");

            // assert

            isAInRole.Should().BeFalse();
        }

        [Fact()]
        public void IsInARole_WithNonMatchingCaseRole_ShouldReturnFalse()
        {
            // arrange

            var currentUser = new CurrentUser("1", "test@tests.com", new List<string> { "Admin", "User" });

            // act

            var isAInRole = currentUser.IsAInRole("admin");

            // assert

            isAInRole.Should().BeFalse();
        }
    }
}