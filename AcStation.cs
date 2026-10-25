public class AcStation : ChargingStation
{
    // Konstruktorn skickar vidare id och sätter maxeffekten till 11.0 kW via "base"
    public AcStation(string id) : base(id, 11.0)
    {
    }

    // Här bestämmer vi att priset för AC-laddning är 3,50 kr per kWh
    public override decimal CalculatePrice(decimal kwh)
    {
        return kwh * 3.50m;
    }
}