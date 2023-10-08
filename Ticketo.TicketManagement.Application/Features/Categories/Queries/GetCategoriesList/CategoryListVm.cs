using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketo.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList
{
    public class CategoryListVm
    {
        public int Id { get; set; }

        public string Name { get; set; } = String.Empty;
    }
}
