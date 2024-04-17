using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;

namespace TailTalks.Services
{
    public class AuthenticationMessageSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Task.FromResult(0);
        }
    }
}
