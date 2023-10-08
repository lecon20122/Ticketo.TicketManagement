using AutoMapper;
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

            CreateMap<Event, EventDetailVm>().ReverseMap();

            CreateMap<Category, CategoryDto>();
        }
    }
}
