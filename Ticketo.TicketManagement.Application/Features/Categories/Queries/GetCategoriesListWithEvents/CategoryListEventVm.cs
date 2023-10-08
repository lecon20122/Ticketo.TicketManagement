using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketo.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents
{
    public class CategoryListEventVm
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public ICollection<CategoryEventDto>? Events { get; set; }
    }
}
