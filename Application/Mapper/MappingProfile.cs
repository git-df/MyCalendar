﻿using Application.Models;
using AutoMapper;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserSignInModel>().ReverseMap();
            CreateMap<User, UserSignUpModel>().ReverseMap();
            CreateMap<User, UserInfoModel>().ReverseMap();
            CreateMap<User, UserDataChangeModel>().ReverseMap();

            CreateMap<EventOnListModel, Event>().ReverseMap();
            CreateMap<Event, EventDetailsModel>()
                .ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.User.FirstName + " " + src.User.LastName));

            CreateMap<Comment, CommentOnEventModel>()
                .ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.User.FirstName + " " + src.User.LastName));
        }
    }
}
