using Logistik;
using System;

Console.Clear();

Lager lager = new Lager();
Produkt banane = new Produkt("Banane", 1001, 2.99m);

banane.ProduktInfoAnzeigen();
System.Console.WriteLine("");
lager.WareEinlagern(banane, 50);
System.Console.WriteLine("");
banane.ProduktInfoAnzeigen();

Console.Read();
