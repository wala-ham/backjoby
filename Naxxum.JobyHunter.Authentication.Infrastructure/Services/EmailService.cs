﻿using Naxxum.JobyHunter.Authentication.Application.User.Interfaces;
using Naxxum.JobyHunter.Authentication.Domain.Settings;
using MimeKit;
using MailKit.Net.Smtp;


using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Naxxum.JobyHunter.Authentication.Application.User.DTOS.Email;
using Naxxum.JobyHunter.Authentication.Application.User.Interfaces.Email;
using Naxxum.JobyHunter.Authentication.Domain.Settings;
using MailKit.Security;
//using System.Net.Mail;

namespace Naxxum.JobyHunter.Authentication.Infrastructure.Services
{
    public class EmailService : IEmailService
    {

        public MailSettings _mailSettings { get; }
        public ILogger<EmailService> _logger { get; }
        public EmailService(IOptions<MailSettings> mailSettings, ILogger<EmailService> logger)
        {
            _mailSettings = mailSettings.Value;
            _logger = logger;
        }

        public async Task SendEmailAsync(EmailRequest request)
        {
            try
            {
                // create message
                var email = new MimeMessage();
                email.Sender = new MailboxAddress(_mailSettings.DisplayName, _mailSettings.Mail);
                email.To.Add(MailboxAddress.Parse(request.ToEmail));
                email.Subject = "Confirm your email";
                var builder = new BodyBuilder();
                builder.HtmlBody = request.Body;
                email.Body = builder.ToMessageBody();
                using var smtp = new SmtpClient();
                smtp.Connect(_mailSettings.Host, _mailSettings.Port, SecureSocketOptions.StartTls);
                smtp.Authenticate(_mailSettings.Mail, _mailSettings.Password);
                await smtp.SendAsync(email);
                smtp.Disconnect(true);

            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                throw new Exception(ex.Message);
            }
        }








    }
}