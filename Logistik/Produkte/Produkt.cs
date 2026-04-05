
namespace Logistik;

public class Produkt
{
    public string? Name { get; set; }
    public int ID { get; set; }
    public string Menge { get; set; }
    public decimal Preis { get; set; }

    public Produkt(string name, int id, string menge = "0")
    {
        Name = name;
        ID = id;
        Menge = menge;
    }

    public void ProduktInfoAnzeigen()
    {
        System.Console.WriteLine("ProduktInformationen: ");

        System.Console.WriteLine($"Name: {Name}");
        System.Console.WriteLine($"ID: {ID}");
        System.Console.WriteLine($"Menge: {Menge}");
        System.Console.WriteLine($"Preis: {Preis} Euro");
    }

    public static void ErstelleNeuesProdukt(string produktName, int id, string produktMenge)
    {
        
        new Produkt(produktName, id, produktMenge);

        System.Console.WriteLine("Produkt wurde angelegt!");
    }
}
