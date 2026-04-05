using System;

namespace Logistik.Lagers;

public class LagerAuslastung
{
    public int LagerKapazität { get; set; }
    public int Bestand { get; set; }
    public int BestandNachWarenEingang { get; set; }

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
