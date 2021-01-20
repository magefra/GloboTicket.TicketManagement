using AutoMapper;
using GloboTicket.TicketManagement.Application.Feactures.Categories.Commands.CreateCateogry;
using GloboTicket.TicketManagement.Application.Feactures.Categories.Queries.GetCategoriesList;
using GloboTicket.TicketManagement.Application.Feactures.Categories.Queries.GetCategoriesListWithEvents;
using GloboTicket.TicketManagement.Application.Feactures.Events.Commands.CreateEvent;
using GloboTicket.TicketManagement.Application.Feactures.Events.Commands.UpdateEvent;
using GloboTicket.TicketManagement.Application.Feactures.Events.Queries.GetEventDetail;
using GloboTicket.TicketManagement.Application.Feactures.Events.Queries.GetEventsExport;
using GloboTicket.TicketManagement.Application.Feactures.Events.Queries.GetEventsList;
using GloboTicket.TicketManagement.Application.Feactures.Orders.GetOrdersForMonth;
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
            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();
            CreateMap<Event, EventExportDto>().ReverseMap();

            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
            CreateMap<Category, CreateCategoryCommand>();
            CreateMap<Category, CreateCategoryDto>();

            CreateMap<Order, OrdersForMonthDto>();
        }
        
    }
}
