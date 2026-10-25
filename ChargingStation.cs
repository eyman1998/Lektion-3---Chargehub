public abstract class ChargingStation : IReportable
{
    public string Id { get; }
    public double MaxKw { get; }

    protected ChargingStation(string id, double maxKw)
    {
        Id = id;
        MaxKw = maxKw;
    }

    public abstract decimal CalculatePrice(decimal kwh);

    // Metoden som interfacet kräver
    public string GetReport()
    {
        return $"Station {Id}: {MaxKw} kW";
    }
}