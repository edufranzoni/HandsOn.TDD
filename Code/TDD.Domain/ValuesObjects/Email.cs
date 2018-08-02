using System;

namespace TDD.Domain.ValuesObjects
{
    public class Email
    {
        public Email(string email)
        {
            Value = email;

            if (!Value.Contains("@"))
                throw new Exception("E-mail inválido!");
        }
        public string Value { get; private set; }
    }
}
