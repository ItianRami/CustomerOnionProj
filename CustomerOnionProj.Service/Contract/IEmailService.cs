using CustomerOnionProj.Domain.Settings;
using System.Threading.Tasks;

namespace CustomerOnionProj.Service.Contract
{
    public interface IEmailService
    {
        Task SendEmailAsync(MailRequest mailRequest);

    }
}
