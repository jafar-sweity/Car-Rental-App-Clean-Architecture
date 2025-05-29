using AutoMapper;
using CarRentalApp.Application.Models.Reservations;
using CarRentalApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
