using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApp.Application.Models.User
{
    public record UserDto
    (
        string FirstName,
           string LastName,
           string Email,
           string PhoneNumber,
           DateTime? DateOfBirth,
           string AddressLine1,
           string AddressLine2,
           string City,
           string Country,
           string DriversLicenseNumber
    );
}
