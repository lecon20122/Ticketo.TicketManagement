using AutoMapper;
using Ticketo.TicketManagement.Application.Features.Categories.Commands.CreateCategory;
using Ticketo.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using Ticketo.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using Ticketo.TicketManagement.Application.Features.Events.Commands.CreateEvent;
using Ticketo.TicketManagement.Application.Features.Events.Commands.UpdateEvent;
using Ticketo.TicketManagement.Application.Features.Events.Queries.GetEventDetail;
using Ticketo.TicketManagement.Application.Features.Events.Queries.GetEventsList;
using Ticketo.TicketManagement.Domain.Entities;

namespace Ticketo.TicketManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();

            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryListEventVm>();
            CreateMap<Category, CreateCategoryCommand>();
            CreateMap<Category, CreateCategoryDto>();
        }
    }
}
