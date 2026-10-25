public class DcStation : ChargingStation
{
    // Konstruktorn sätter maxeffekten till 150.0 kW
    public DcStation(string id) : base(id, 150.0)
    {
    }

    // DC-laddning kostar 5,00 kr per kWh PLUS 10 kr i startavgift
    public override decimal CalculatePrice(decimal kwh)
    {
        return (kwh * 5.00m) + 10.0m;
    }
}