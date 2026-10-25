public class Vehicle
{
    public int Id { get; }
    public double MaxKwh { get; }
    public double Percent { get; set; } = 0; // Börjar på 0 % enligt uppgiftens utskrift

    public Vehicle(int id, double maxKwh)
    {
        Id = id;
        MaxKwh = maxKwh;
    }
}