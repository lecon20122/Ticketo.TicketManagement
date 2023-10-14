using MediatR;
using Microsoft.AspNetCore.Mvc;
using Ticketo.TicketManagement.Application.Features.Events.Commands.CreateEvent;
using Ticketo.TicketManagement.Application.Features.Events.Commands.DeleteEvent;
using Ticketo.TicketManagement.Application.Features.Events.Commands.UpdateEvent;
using Ticketo.TicketManagement.Application.Features.Events.Queries.GetEventDetail;
using Ticketo.TicketManagement.Application.Features.Events.Queries.GetEventsExport;
using Ticketo.TicketManagement.Application.Features.Events.Queries.GetEventsList;

namespace Ticketo.TicketManagement.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EventsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<EventListVm>>> GetAllEvents()
        {
            var dtos = await _mediator.Send(new GetEventsListQuery());

            return Ok(dtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EventDetailVm>> GetEventById(int id)
        {
            var getEventDetailQuery = new GetEventDetailQuery() { Id = id };
            return Ok(await _mediator.Send(getEventDetailQuery));
        }


        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody] CreateEventCommand createEventCommand)
        {
            return Ok(await _mediator.Send(createEventCommand));
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] UpdateEventCommand update)
        {
            await _mediator.Send(update);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            DeleteEventCommand deleteCommand = new DeleteEventCommand() { Id = id };
            await _mediator.Send(deleteCommand);
            return NoContent();
        }


        [HttpGet("export")]
        public async Task<FileResult> ExportEvents()
        {
            var fileDto = await _mediator.Send(new GetEventExportQuery());

            return File(fileDto.Data, fileDto.ContentType, fileDto.EventExportFileName);
        }
    }
}
