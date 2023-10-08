using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketo.TicketManagement.Application.Features.Events;
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
