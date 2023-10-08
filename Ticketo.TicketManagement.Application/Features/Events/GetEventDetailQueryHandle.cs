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
    public class GetEventDetailQueryHandle : IRequestHandler<GetEventDetailQuery, EventDetailVm>
    {
        private readonly IAsyncRepository<Category> _categoryRepositorty;
        private readonly IAsyncRepository<Event> _eventRepository;
        private readonly IMapper _mapper;

        public GetEventDetailQueryHandle(IAsyncRepository<Category> categoryRepositorty, IAsyncRepository<Event> eventRepository, IMapper mapper)
        {
            _categoryRepositorty = categoryRepositorty;
            _eventRepository = eventRepository;
            _mapper = mapper;
        }

        public async Task<EventDetailVm> Handle(GetEventDetailQuery request, CancellationToken cancellationToken)
        {
            var @event = await _eventRepository.GetByIdAsync(request.Id);

            var eventDetailDto = _mapper.Map<EventDetailVm>(@event);

            var category = await _categoryRepositorty.GetByIdAsync(eventDetailDto.CategoryId);

            eventDetailDto.Category = _mapper.Map<CategoryDto>(category);

            return eventDetailDto;
        }
    }
}
