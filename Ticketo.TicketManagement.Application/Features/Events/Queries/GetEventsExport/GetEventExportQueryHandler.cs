using AutoMapper;
using MediatR;
using Ticketo.TicketManagement.Application.Contracts.Infrastructure;
using Ticketo.TicketManagement.Application.Contracts.Persistence;

namespace Ticketo.TicketManagement.Application.Features.Events.Queries.GetEventsExport
{
    public class GetEventExportQueryHandler : IRequestHandler<GetEventExportQuery, EventExportFileVm>
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;
        private readonly ICsvExporter _csvExporter;

        public GetEventExportQueryHandler(IEventRepository eventRepository, IMapper mapper, ICsvExporter csvExporter)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
            _csvExporter = csvExporter;
        }
        public async Task<EventExportFileVm> Handle(GetEventExportQuery request, CancellationToken cancellationToken)
        {
            var allEvents = (await _eventRepository.ListAllAsync()).OrderBy(x => x.Date);

            var eventExportDtos = _mapper.Map<List<EventExportDto>>(allEvents);

            var fileData = _csvExporter.ExportEventsToCsv(eventExportDtos);

            return new EventExportFileVm()
            {
                ContentType = "text/csv",

                Data = fileData,

                EventExportFileName = $"{Guid.NewGuid()}.csv"
            };
        }
    }
}
