using CarRentalApp.Application.Models.User;
using FluentValidation;

namespace CarRentalApp.Application.Validatiors.Users
{
    public class UserCreateValidator : AbstractValidator<UserCreateDto>
    {
        public UserCreateValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First Name is required");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last Name is required");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Invalid email format");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Phone Number is required");
        }
    }
}
