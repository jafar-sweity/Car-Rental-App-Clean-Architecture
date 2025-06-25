namespace CarRentalApp.Application.Models.Car
{
    public record CarUpdateDto
    (
        string Brand,
        string Model,
        decimal PricePerDay,
        bool IsAvailable
    );
}
