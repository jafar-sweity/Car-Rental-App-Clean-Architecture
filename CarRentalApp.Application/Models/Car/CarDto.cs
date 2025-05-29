using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApp.Application.Models.Car
{
    public record CarDto
    (
        int Id,
        string Brand,
        string Model,
        decimal PricePerDay,
        bool IsAvailable
    );
}
