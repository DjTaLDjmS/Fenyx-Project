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
            CreateMap<UserContract, User>();
            CreateMap<User, UserContract>();

            CreateMap<UserListItemContract, User>();
            CreateMap<User, UserListItemContract>();
        }
    }
}