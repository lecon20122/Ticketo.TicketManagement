using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketo.TicketManagement.Domain.Common
{
    public class AuditableEntity
    {
        public int? CreatedBy { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime CreatedDate { get; set;}
        public DateTime LastModifiedDate { get; set;}
    }
}
