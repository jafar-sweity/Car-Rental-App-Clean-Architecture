using AutoMapper;
using CarRentalApp.Application.Models.User;
using CarRentalApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApp.Application.Profiles
{
    class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User,UserDto>().ReverseMap();
            CreateMap<UserCreateDto,User>();
            CreateMap<UserUpdateDto,User>().ReverseMap();
        }
    }
}
