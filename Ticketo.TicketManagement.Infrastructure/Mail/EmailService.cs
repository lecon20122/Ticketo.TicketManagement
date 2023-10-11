using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using Ticketo.TicketManagement.Application.Contracts.Infrastructure;
using Ticketo.TicketManagement.Application.Models.Mail;

namespace Ticketo.TicketManagement.Infrastructure.Mail
{
    public class EmailService : IEmailService
    {
        public EmailSettings _emailSettings;

        public EmailService(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public async Task<bool> SendEmail(Email email)
        {
            var client = new SendGridClient(_emailSettings.ApiKey);

            var subject = email.Subject;
            var to = new EmailAddress(email.To);
            var body = email.Body;

            var from = new EmailAddress
            {
                Email = _emailSettings.FromAddress,
                Name = _emailSettings.FromName
            };

            var sendGridMessage = MailHelper.CreateSingleEmail(from, to, subject, body, body);

            var response = await client.SendEmailAsync(sendGridMessage);

            if (response.StatusCode == System.Net.HttpStatusCode.Accepted ||
                               response.StatusCode == System.Net.HttpStatusCode.OK)
                return true;

            return false;
        }
    }
}
