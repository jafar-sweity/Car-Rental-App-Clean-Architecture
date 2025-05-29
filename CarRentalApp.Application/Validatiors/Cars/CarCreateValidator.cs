using CarRentalApp.Application.Models.Car;
using FluentValidation;

namespace CarRentalApp.Application.Validatiors.Cars
{
    class CarCreateValidator : AbstractValidator<CarCreateDto>
    {
        public CarCreateValidator()
        {
            RuleFor(car => car.Model).NotEmpty().WithMessage("Model is required.");
            RuleFor(car => car.Brand).NotEmpty().WithMessage("Brand is required.");
            RuleFor(x => x.PricePerDay).GreaterThan(0).WithMessage("Price per day must be greater than 0");

        }
    }
}
