using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketo.TicketManagement.Domain.Common;

namespace Ticketo.TicketManagement.Domain.Entities
{
    public class Event : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public int Price { get; set; }
        public string? Artist { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Date { get; set; }
        public Category Category { get; set; } = default!;
        public int CategoryId { get; set; }
    }
}
