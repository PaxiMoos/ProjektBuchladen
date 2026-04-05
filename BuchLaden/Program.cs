using Logistik;

Lager lager = new Lager();
Produkt banane = new Produkt("Banane", 1001, "20");
Produkt apfel = new Produkt("Apfel", 1002, "50");

lager.WareEinlagern(banane, banane.Menge);
lager.WareEinlagern(apfel, apfel.Menge);

System.Console.WriteLine("");
lager.WarenBestandAnzeigen();

System.Console.WriteLine("");
lager.KapzitätAnzeigen();

