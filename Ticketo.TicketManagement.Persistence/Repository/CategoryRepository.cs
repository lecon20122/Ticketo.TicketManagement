using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketo.TicketManagement.Application.Contracts.Persistence;
using Ticketo.TicketManagement.Domain.Entities;

namespace Ticketo.TicketManagement.Persistence.Repository
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public async Task<List<Category>> GetCategoriesWithEvents(bool includePassedEvents)
        {
            var categoriesWithEvents = await _applicationDbContext.Categories
                    .Include(c => c.Events).ToListAsync();

            if (!includePassedEvents)
            {
                categoriesWithEvents.ForEach(c => c.Events.ToList().RemoveAll(e => e.Date < DateTime.Today));
            }

            return categoriesWithEvents;
        }
    }
}
