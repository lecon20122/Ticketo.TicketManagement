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
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public async Task<List<Order>> GetPagedOrdersForMonth(DateTime date, int page, int size)
        {
            return await _applicationDbContext.Orders
                .Where(o => o.OrderPlaced.Month == date.Month && o.OrderPlaced.Year == date.Year)
                .Skip((page - 1) * size)
                .Take(size)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<int> GetTotalCountOfOrdersForMonth(DateTime date)
        {
            return await _applicationDbContext.Orders
                .CountAsync(o => o.OrderPlaced.Month == date.Month && o.OrderPlaced.Year == date.Year);
        }
    }
}
