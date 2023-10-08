using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketo.TicketManagement.Application.Features.Events.Queries.GetEventDetail
{
    public class GetEventDetailQuery : IRequest<EventDetailVm>
    {
        public int Id { get; set; }
    }
}
