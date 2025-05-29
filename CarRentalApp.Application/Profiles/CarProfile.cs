using AutoMapper;
using CarRentalApp.Application.Models.Car;
using CarRentalApp.Core.Entities;


namespace CarRentalApp.Application.Profiles
{
    class CarProfile : Profile
    {
        public CarProfile()
        {
            CreateMap<Car, CarDto>().ReverseMap();
            CreateMap<CarCreateDto, Car>();
            CreateMap<CarUpdateDto, Car>().ReverseMap();
        }
    }
}
