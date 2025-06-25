namespace CarRentalApp.Application.Models.Car
{
    public record CarCreateDto
    (
        string Brand,
        string Model,
        decimal PricePerDay,
        bool IsAvailable
    );
}
