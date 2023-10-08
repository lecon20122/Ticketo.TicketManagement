using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketo.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents
{
    public class GetCategoriesListWithEventQuery : IRequest<List<CategoryListEventVm>>
    {
        public bool IncludeHistory { get; set; }
    }
}
