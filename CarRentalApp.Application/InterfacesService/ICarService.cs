using CarRentalApp.Application.Models.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApp.Application.InterfacesService
{
    public interface ICarService
    {
        Task<List<CarDto>> GetAvailableCarsAsync();
        Task<CarDto> GetCarByIdAsync(int id);
        Task AddCarAsync(CarCreateDto carCreateDto);
        Task UpdateCarAsync(int id, CarUpdateDto carUpdateDto);
        Task DeleteCarAsync(int id);
    }
}
