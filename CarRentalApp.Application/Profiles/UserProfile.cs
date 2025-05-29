using AutoMapper;
using CarRentalApp.Application.Models.User;
using CarRentalApp.Infrastructure;

namespace CarRentalApp.Application.Profiles
{
    class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<UserCreateDto, User>();
            CreateMap<UserUpdateDto, User>().ReverseMap();
        }
    }
}
