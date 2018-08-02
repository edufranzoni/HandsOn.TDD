using TDD.Domain.Helpers.Interfaces;

namespace TDD.Tests.Mocks
{
    public class EmailHelperMock : IEmailHelper
    {
        public void Send(string to, string from, string subject, string body)
        {
            //
        }
    }
}
