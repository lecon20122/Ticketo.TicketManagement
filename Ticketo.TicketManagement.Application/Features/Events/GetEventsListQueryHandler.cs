using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketo.TicketManagement.Application.Contracts.Persistence;
using Ticketo.TicketManagement.Domain.Entities;

namespace Ticketo.TicketManagement.Application.Features.Events
{
    public class GetEventsListQueryHandler : IRequestHandler<GetEventsListQuery, List<EventListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Event> _asyncRepository;

        public GetEventsListQueryHandler(IMapper mapper, IAsyncRepository<Event> asyncRepository)
        {
            _mapper = mapper;
            _asyncRepository = asyncRepository;
        }

        public async Task<List<EventListVm>> Handle(GetEventsListQuery request, CancellationToken cancellationToken)
        {
            var allEvents = (await _asyncRepository.ListAllAsync()).OrderBy(x => x.Date);

            return _mapper.Map<List<EventListVm>>(allEvents);
        }
    }
}
