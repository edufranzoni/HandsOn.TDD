namespace TDD.Domain.Helpers.Interfaces
{
    public interface IEmailHelper
    {
        void Send(string to, string from, string subject, string body);
    }
}
