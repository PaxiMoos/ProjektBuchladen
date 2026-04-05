using System;

namespace Logistik;

public class Produkt
{
    public string? Name { get; set; }
    public int ID { get; set; }
    public decimal Preis { get; set; }

    public Produkt(string name, int id, decimal preis)
    {
        Name = name;
        ID = id;
        Preis = preis;
    }

    public void ProduktInfoAnzeigen()
    {
        System.Console.WriteLine("ProduktInformationen: ");

        System.Console.WriteLine($"Name: {Name}");
        System.Console.WriteLine($"ID: {ID}");
        System.Console.WriteLine($"Preis: {Preis} Euro");
    }
}
