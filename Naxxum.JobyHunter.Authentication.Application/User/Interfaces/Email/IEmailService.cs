using Naxxum.JobyHunter.Authentication.Application.User.DTOS.Account;
using Naxxum.JobyHunter.Authentication.Application.User.DTOS.Email;


namespace Naxxum.JobyHunter.Authentication.Application.User.Interfaces.Email
{
    public interface IEmailService
    {
        Task SendEmailAsync(EmailRequest request);

    }
}