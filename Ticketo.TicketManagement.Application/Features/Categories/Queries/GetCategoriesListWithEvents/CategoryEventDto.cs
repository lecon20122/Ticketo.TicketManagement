﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketo.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents
{
    public class CategoryEventDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public int Price { get; set; }
        public DateTime Date { get; set; }
        public string? Artist { get; set; }
        public int CategoryId { get; set; }
    }
}
