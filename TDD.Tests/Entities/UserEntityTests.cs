using FluentAssertions;
using System;
using TDD.Domain.Entities;
using TDD.Domain.ValuesObjects;
using Xunit;

namespace TDD.Tests.Entities
{
    public class UserEntityTests
    {
        [Fact]
        public void UserEntityNewInstanceShouldNotThrow()
        {
            //Arrange
            var email = new Email("testes@gmail.com");

            //Act
            Action action = () => 
            {
                var user = new UserEntity("Backlog Produtos", email);
            };

            //Assert
            action.Should().NotThrow();
        }

        [Fact]
        public void UserEntityNewInstanceShouldThrowInvalidEmailException()
        {
            //Act
            Action action = () =>
            {
                //Arrange
                var email = new Email("testes");
                var user = new UserEntity("Backlog Produtos", email);
            };

            //Assert
            action.Should().Throw<Exception>();
        }
    }
}
