using System;

namespace Logistik;

public class Lager
{
    public List<Produkt> lagerWare = new List<Produkt>();

    public int Kapzität { get; set; }
    public int Bestand { get; set; }
    public int BestandNachWarenEingan { get; set; }
    public string? LagerPlatzBananen { get; set; } = "Bananen";

    public Lager()
    {
        
    }

    public void WareEinlagern(Produkt p, string menge)
    {
        p.Menge = menge;
        lagerWare.Add(p);

        System.Console.WriteLine($"{p.Menge}x {p.Name} wurden auf den Lagerplatz: '{LagerPlatzBananen}' eingelagert.");
    }
}
