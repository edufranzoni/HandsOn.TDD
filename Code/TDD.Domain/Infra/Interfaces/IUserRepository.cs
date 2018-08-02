using TDD.Domain.Entities;

namespace TDD.Domain.Infra.Interfaces
{
    public interface IUserRepository
    {
        bool UserExist(UserEntity user);
        void Create(UserEntity user);
    }
}
