using FluentAssertions;
using System;
using TDD.Domain.Entities;
using TDD.Domain.Helpers.Interfaces;
using TDD.Domain.Infra.Interfaces;
using TDD.Domain.Services;
using TDD.Domain.ValuesObjects;
using TDD.Tests.Mocks;
using Xunit;

namespace TDD.Tests.Services
{
    public class UserServiceTests
    {
        private readonly UserService _userService;
        
        public UserServiceTests()
        {
            IUserRepository userRepository = new UserRepositoryMock();
            IEmailHelper emailHelper = new EmailHelperMock();
            _userService = new UserService(userRepository, emailHelper);
        }

        [Fact]
        public void UserServiceCreateNewUserShoultNotThrow()
        {
            //Arrange
            var email = new Email("testes@gmail.com");
            var user = new UserEntity("Backlog Produtos", email);
            
            //Act
            Action action = () => { _userService.CreateNewUser(user); };

            //Assert
            action.Should().NotThrow();
        }
    }
}
