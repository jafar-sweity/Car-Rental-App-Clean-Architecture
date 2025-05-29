using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApp.Application.Models.Reservations
{
    public record ReservationDto
    (
        int Id,
        int CarId,
        int UserId,
        DateTime StartDate,
        DateTime EndDate,
        decimal TotalCost
    );
}
