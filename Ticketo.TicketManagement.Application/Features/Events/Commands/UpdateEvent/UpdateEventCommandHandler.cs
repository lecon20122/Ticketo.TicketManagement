using AutoMapper;
using MediatR;
using Ticketo.TicketManagement.Application.Contracts.Persistence;
using Ticketo.TicketManagement.Domain.Entities;

namespace Ticketo.TicketManagement.Application.Features.Events.Commands.UpdateEvent
{
    public class UpdateEventCommandHandler : IRequestHandler<UpdateEventCommand>
    {
        private readonly IMapper _mapper;
        private readonly IEventRepository _eventRepository;

        public UpdateEventCommandHandler(IMapper mapper, IEventRepository eventRepository)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
        }
        public async Task Handle(UpdateEventCommand request, CancellationToken cancellationToken)
        {
            var @event = await _eventRepository.GetByIdAsync(request.Id);

            _mapper.Map<UpdateEventCommand, Event>(request, @event);

            await _eventRepository.UpdateAsync(@event);
        }
    }
}
