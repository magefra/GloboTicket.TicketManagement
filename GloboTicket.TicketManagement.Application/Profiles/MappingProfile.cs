using AutoMapper;
using GloboTicket.TicketManagement.Application.Feactures.Events.Queries.GetEventDetail;
using GloboTicket.TicketManagement.Application.Feactures.Events.Queries.GetEventsList;
using GloboTicket.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GloboTicket.TicketManagement.Application.Profiles
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
