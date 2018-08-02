using System;
using TDD.Domain.Entities;
using TDD.Domain.Helpers.Interfaces;
using TDD.Domain.Infra.Interfaces;

namespace TDD.Domain.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IEmailHelper _emailHelper;
        public UserService(IUserRepository userRepository, IEmailHelper emailHelper)
        {
            _userRepository = userRepository;
            _emailHelper = emailHelper;
        }
        public void CreateNewUser(UserEntity user)
        {
            //Email não pode existir na base.
            if (_userRepository.UserExist(user))
                throw new Exception("Usuário já existe!");

            //Cadastrar.
            _userRepository.Create(user);

            //Enviar e-mail de confirmação.
            _emailHelper.Send(user.Email.Value, "sistemas@sistemas.com.br", "Cadastro realizado", "Parabens");
        }
    }
}
