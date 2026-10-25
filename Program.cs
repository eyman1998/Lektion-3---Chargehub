using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var ac1 = new AcStation("AC-01");
        var ac2 = new AcStation("AC-02");
        var dc1 = new DcStation("DC-01");

        // Skapar listan med dagens laddningar
        var sessions = new List<(ChargingStation Station, decimal Kwh)>
        {
            (ac1, 20m), (dc1, 20m), (ac2, 12m), (dc1, 40m)
        };

        decimal totalRevenue = 0;

        // Loopar igenom listan och lägger ihop priserna
        foreach (var session in sessions)
        {
            totalRevenue += session.Station.CalculatePrice(session.Kwh);
        }

        Console.WriteLine($"Dagens totala intäkter: {totalRevenue} kr");
    }
}