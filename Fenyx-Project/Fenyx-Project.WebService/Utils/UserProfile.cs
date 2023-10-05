using Fenyx_Project.WebService.Contracts;
using Fenyx_Project.WebService.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppForm.WebServices.Utils
{
    public class UserProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<UserContract, User>()
                .ForMember(dest => dest.Address, act => act.MapFrom(src => new Address() {
                    Id = src.Id,
                    Street = src.AddressStreet,
                    Zipcode = src.AddressZipcode,
                    City = src.AddressCity
                }));
            CreateMap<User, UserContract>()
                .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.AddressStreet, act => act.MapFrom(src => src.Address.Street))
                .ForMember(dest => dest.AddressZipcode, act => act.MapFrom(src => src.Address.Zipcode))
                .ForMember(dest => dest.AddressCity, act => act.MapFrom(src => src.Address.City)); ;

            CreateMap<UserListItemContract, User>();
            CreateMap<User, UserListItemContract>();
        }
    }
}