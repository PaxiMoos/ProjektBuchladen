using System;

namespace Logistik.Produkte;

public abstract class WareAllgemein
{
    public string? Name { get; set; }
    public int ID { get; set; }
    public string? Menge { get; set; }
    public decimal Preis { get; set; }

    public void ProduktInfoAnzeigen()
    {
        System.Console.WriteLine("ProduktInformationen: ");

        System.Console.WriteLine($"Name: {Name}");
        System.Console.WriteLine($"ID: {ID}");
        System.Console.WriteLine($"Menge: {Menge}");
        System.Console.WriteLine($"Preis: {Preis} Euro");
    }
}

