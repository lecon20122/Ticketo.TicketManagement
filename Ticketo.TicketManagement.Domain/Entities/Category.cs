using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketo.TicketManagement.Domain.Common;

namespace Ticketo.TicketManagement.Domain.Entities
{
    public class Category : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public ICollection<Event>? Events { get; set; }
    }
}
