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
