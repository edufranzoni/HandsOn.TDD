using TDD.Domain.Entities;
using TDD.Domain.Infra.Interfaces;

namespace TDD.Tests.Mocks
{
    public class UserRepositoryMock : IUserRepository
    {
        public void Create(UserEntity user)
        {
            //Não faz nada, é meu mock!!!
        }

        public bool UserExist(UserEntity user)
        {
            return false;
        }
    }
}
