using FluentAssertions;
using System;
using TDD.Domain.ValuesObjects;
using Xunit;

namespace TDD.Tests.ValueObjects
{
    public class EmailTests
    {
        [Theory]
        [InlineData("teste@gmail.com")]
        [InlineData("teste@hotmail.com")]
        [InlineData("teste@outlook.com")]
        [Trait("Category", "ValueObjects")]
        public void EmailNewInstanceShouldNotThrow(string emailValue)
        {
            //Arrange e //Act
            Action action = () =>
            {
                var email = new Email(emailValue);                
            };

            //Assert
            action.Should().NotThrow();
        }

        [Theory]
        [InlineData("teste")]
        [InlineData("teste.com.br")]
        [InlineData("teste.br")]
        [Trait("Category", "ValueObjects")]
        public void EmailNewInstanceShouldThrowInvalidEmailException(string emailValue)
        {
            //Arrange e //Act
            Action action = () =>
            {
                var email = new Email(emailValue);                
            };

            //Assert
            action.Should().Throw<Exception>();
        }
    }
}
