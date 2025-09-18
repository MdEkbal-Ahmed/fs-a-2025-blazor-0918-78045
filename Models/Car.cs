 namespace FleetManager.Models
{
    public class Car
{
    public int Id { get; set; }              // Unique identifier
    public string? Make { get; set; }         // e.g., Toyota
    public string? Model { get; set; }        // e.g., Corolla
    public int Year { get; set; }            // e.g., 2020
    public string? Color { get; set; }        // e.g., Red
    public int Mileage { get; set; }         // e.g., 45000
}
}
