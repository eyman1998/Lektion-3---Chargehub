using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // 1. Skapa objekten (Bil 1, AC-01 och DC-01)
        var bil1 = new Vehicle(1, 75);
        var ac1 = new AcStation("AC-01");
        var dc1 = new DcStation("DC-01");

        // 2. Samla dem i en gemensam lista av typen IReportable
        var reportables = new List<IReportable>
        {
            bil1,
            ac1,
            dc1
        };

        // 3. Loopa igenom och anropa interfacet
        foreach (var item in reportables)
        {
            Console.WriteLine(item.GetReport());
        }
    }
}