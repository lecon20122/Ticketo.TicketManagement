using MediatR;
using Microsoft.AspNetCore.Mvc;
using Ticketo.TicketManagement.Application.Features.Categories.Commands.CreateCategory;
using Ticketo.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using Ticketo.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;

namespace Ticketo.TicketManagement.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<List<CategoryListVm>>> GetAllCategories()
        {
            var dtos = await _mediator.Send(new GetCategoriesListQuery());

            return Ok(dtos);
        }

        [HttpGet]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<CategoryListEventVm>>> GetCategoriesWithEvents(bool includeHistory)
        {
            GetCategoriesListWithEventQuery query = new() { IncludeHistory = includeHistory };

            var dtos = await _mediator.Send(query);

            return Ok(dtos);
        }

        [HttpPost]
        public async Task<ActionResult<CreateCategoryCommandResponse>> Create([FromBody] CreateCategoryCommand createCategoryCommand)
        {
            var response = await _mediator.Send(createCategoryCommand);
            return Ok(response);
        }
    }
}
