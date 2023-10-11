using Ticketo.TicketManagement.Application.Models.Mail;

namespace Ticketo.TicketManagement.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
