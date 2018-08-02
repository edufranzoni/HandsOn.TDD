using System;
using TDD.Domain.ValuesObjects;

namespace TDD.Domain.Entities
{
    public class UserEntity
    {
        public UserEntity(string name, Email email)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;            
        }
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public Email Email { get; private set; } 
    }
}
