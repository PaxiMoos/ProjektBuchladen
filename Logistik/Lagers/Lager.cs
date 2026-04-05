using System;

namespace Logistik;

public class Lager
{
    public List<Produkt> lagerWare = new List<Produkt>();

    public int Kapzität { get; set; } = 100;
    public int Bestand { get; set; } = 0;
    public int BestandNachWarenEingan { get; set; } = 0;
    public string? LagerPlatzBananen { get; set; } = "Bananen";
    public string? LagerPlatzÄpfel { get; set; } = "Äpfel";

    public Lager()
    {

    }

    public void WareEinlagern(Produkt p, string menge)
    {
        BestandNachWarenEingan += Convert.ToInt32(menge);

        if (BestandNachWarenEingan <= Kapzität)
        {
            Bestand += Convert.ToInt32(menge);

            if (p.Name == "Banane")
            {
                lagerWare.Add(p);
                System.Console.WriteLine($"{p.Menge}x {p.Name} wurden auf den Lagerplatz: {LagerPlatzBananen} hinzugefügt.");
            }

            else if (p.Name == "Apfel")
            {
                lagerWare.Add(p);
                System.Console.WriteLine($"{p.Menge}x {p.Name} wurden auf den Lagerplatz: {LagerPlatzÄpfel} hinzugefügt.");
            }
        }
    }

    public void WarenBestandAnzeigen()
    {
        System.Console.WriteLine($"LagerBestand: ");

        foreach (Produkt p in lagerWare)
        {
            System.Console.WriteLine($"{p.Menge}x {p.Name}");
        }
    }

    public void KapzitätAnzeigen()
    {
        System.Console.WriteLine($"Aktuelle LagerKapazität: {Bestand} %.");
    }
}
