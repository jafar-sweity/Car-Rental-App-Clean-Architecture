using AutoMapper;
using CarRentalApp.Application.Models.Reservations;
using CarRentalApp.Core.Entities;

namespace CarRentalApp.Application.Profiles
{
    class ReservationProfile : Profile
    {
        public ReservationProfile()
        {
            CreateMap<Reservation, ReservationDto>().ReverseMap();
            CreateMap<ReservationCreateDto, Reservation>();
            CreateMap<ReservationUpdateDto, Reservation>().ReverseMap();
        }
    }
}
