﻿using AutoMapper;
using GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventDetail;
using GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventsList;
using GloboTicket.TicketManagement.Domain.Entities;
using GloboTicket.TicketManagement.Application.Features.Events.Commands.CreateEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            //Mapping between Event and EventListVm
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();

            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryListVm>().ReverseMap();
            CreateMap<Category, CategoryEventListVm>().ReverseMap();

            CreateMap<Event, CreateEventCommand>().ReverseMap();

        }
    }
}
