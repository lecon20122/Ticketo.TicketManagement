using Microsoft.EntityFrameworkCore;
using Ticketo.TicketManagement.Application.Contracts.Persistence;
using Ticketo.TicketManagement.Domain.Entities;

namespace Ticketo.TicketManagement.Persistence.Repository
{
    public class EventRepository : BaseRepository<Event>, IEventRepository
    {
        public EventRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public async Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate)
        {
            return await _applicationDbContext.Events
                .AnyAsync(e => e.Name.Equals(name) && e.Date.Date.Equals(eventDate.Date));
        }
    }
}
