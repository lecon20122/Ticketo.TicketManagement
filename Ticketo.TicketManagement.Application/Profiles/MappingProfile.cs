using AutoMapper;
using Ticketo.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using Ticketo.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using Ticketo.TicketManagement.Application.Features.Events.Queries.GetEventDetail;
using Ticketo.TicketManagement.Application.Features.Events.Queries.GetEventsList;
using Ticketo.TicketManagement.Domain.Entities;

namespace Ticketo.TicketManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>();
            CreateMap<Event, EventDetailVm>();
            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryListEventVm>();
        }
    }
}
