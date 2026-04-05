using System;

namespace Logistik.BenutzerEingaben;

public static class BenutzerEingabe
{
    public static (string? produktName, string ?produktMenge) ProduktAnlegen()
    {
        System.Console.WriteLine("Lege ein Produkt an.");

        System.Console.WriteLine("Wie heißt dein Produkt?");
        Console.Write("Name: ");
        string? produktName = Console.ReadLine();

        System.Console.WriteLine("Und wie oft gibt es dieses Produkt?");
        Console.Write("Anzahl: ");
        string? produktMenge = Console.ReadLine();

        System.Console.WriteLine("Produkt wurde angelegt!");

        return (produktName, produktMenge);
    }
}
