public class Vehicle : IReportable
{
    public int Id { get; }
    public double MaxKwh { get; }
    public double Percent { get; set; } = 0; 

    public Vehicle(int id, double maxKwh)
    {
        Id = id;
        MaxKwh = maxKwh;
    }

    // Metoden som interfacet kräver
    public string GetReport()
    {
        return $"Bil {Id}: {Percent} %";
    }
}