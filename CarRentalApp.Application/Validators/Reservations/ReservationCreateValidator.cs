using CarRentalApp.Application.Models.Reservations;
using FluentValidation;

namespace CarRentalApp.Application.Validatiors.Reservations
{
    public class ReservationCreateValidator : AbstractValidator<ReservationCreateDto>
    {
        public ReservationCreateValidator()
        {
            RuleFor(x => x.CarId).GreaterThan(0).WithMessage("CarId is required");
            RuleFor(x => x.UserId).GreaterThan(0).WithMessage("UserId is required");
            RuleFor(x => x.StartDate).LessThan(x => x.EndDate).WithMessage("StartDate must be before EndDate");
            RuleFor(x => x.TotalCost).GreaterThan(0).WithMessage("Total cost must be greater than 0");
        }
    }
}
