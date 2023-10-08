using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketo.TicketManagement.Application.Features.Events.Queries.GetEventDetail
{
    public class EventDetailVm
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Artist { get; set; }

        public DateTime Date { get; set; }

        public int Price { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }

        public CategoryDto Category { get; set; } = default!;

        public int CategoryId { get; set; }
    }
}
