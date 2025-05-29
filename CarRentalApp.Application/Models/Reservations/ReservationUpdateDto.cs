namespace CarRentalApp.Application.Models.Reservations
{
    public record ReservationUpdateDto
    (
      int CarId,
      int UserId,
      DateTime StartDate,
      DateTime EndDate,
      decimal TotalCost
    );
}
