namespace CarRentalApp.Application.Models.Reservations
{
    public record ReservationCreateDto
    (
       int CarId,
       int UserId,
       DateTime StartDate,
       DateTime EndDate,
       decimal TotalCost
    );
}
