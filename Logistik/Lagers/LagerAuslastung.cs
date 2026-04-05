using System;

namespace Logistik.Lagers;

public class LagerAuslastung
{
    public int LagerKapazität { get; set; } = 100;
    public int Bestand { get; set; } = 0;
    public int BestandNachWarenEingang { get; set; } = 0;

    public void LagerAuslastungAnzeigen()
    {
        System.Console.WriteLine($"Die Lagerauslastung liegt bei {LagerKapazität} %.");
    }

    public void LagerFastVoll()
    {
        if (Bestand > 80)
        {
            System.Console.WriteLine("Das Lager ist fast voll, bittet verkauft Ware.");
        }
    }

    public void LagerFastLeer()
    {
        if (Bestand < 20)
        {
            System.Console.WriteLine("Das Lager ist fast leer, bitt kauft mehr Ware ein.");
        }
    }
}
