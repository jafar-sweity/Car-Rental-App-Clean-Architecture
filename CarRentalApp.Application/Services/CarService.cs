using AutoMapper;
using CarRentalApp.Application.InterfacesService;
using CarRentalApp.Application.Models.Car;
using CarRentalApp.Core.Entities;
using CarRentalApp.Core.InterfacesRepository;

namespace CarRentalApp.Application.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public CarService(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository ?? throw new ArgumentNullException(nameof(carRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task AddCarAsync(CarCreateDto carCreateDto)
        {
            var car = _mapper.Map<Car>(carCreateDto);
            await _carRepository.AddCarAsync(car);
        }

        public async Task DeleteCarAsync(int id)
        {
            await _carRepository.DeleteCarAsync(id);
        }

        public async Task<List<CarDto>> GetAvailableCarsAsync()
        {
            var cars = await _carRepository.GetAvailableCarsAsync();
            return _mapper.Map<List<CarDto>>(cars);
        }

        public async Task<CarDto> GetCarByIdAsync(int id)
        {
            var existingCar = await _carRepository.GetCarByIdAsync(id);
            return existingCar == null ? throw new KeyNotFoundException($"Car with ID {id} not found.") : _mapper.Map<CarDto>(existingCar);
        }

        public async Task UpdateCarAsync(int id, CarUpdateDto carUpdateDto)
        {
            var car = await _carRepository.GetCarByIdAsync(id);

            if (car != null)
            {
                _mapper.Map(carUpdateDto, car);
                await _carRepository.UpdateCarAsync(car);
            }
        }
    }
}
