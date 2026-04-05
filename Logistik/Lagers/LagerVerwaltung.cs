using System;
using Logistik.Produkte;

namespace Logistik.Lagers;

public class LagerVerwaltung
{
    private Lager lager = new Lager();

    public void WareEinlagern(WareAllgemein w, string menge)
    {
        lager.lagerAuslastung.BestandNachWarenEingang += Convert.ToInt32(menge);

        if (w.Name == "Banane")
        {
            lager.lagerAuslastung.Bestand += Convert.ToInt32(menge);
            lager.lagerWare.Add(w);

            System.Console.WriteLine($"{w.Menge}x {w.Name} wurden auf den Lagerplatz: {lager.lagerPlatzBananen} eingelagert.");
        }
    }
}
