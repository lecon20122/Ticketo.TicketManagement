﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketo.TicketManagement.Domain.Common;

namespace Ticketo.TicketManagement.Domain.Entities
{
    public class Order : AuditableEntity
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int OrderTotal { get; set; }

        public DateTime OrderPlaced { get; set; }

        public bool OrderPaid { get; set; }
    }
}
