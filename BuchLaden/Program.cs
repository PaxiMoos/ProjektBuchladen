using Logistik;
using Logistik.Lagers;
using Logistik.Produkte;

LagerVerwaltung? lagerVerwaltung = new LagerVerwaltung();
WareAllgemein? banane = new Banane("Banane", 1001, "30");
lagerVerwaltung.WareEinlagern(banane, banane.Menge);

System.Console.WriteLine("");
lagerVerwaltung.lager.lagerAuslastung.LagerAuslastungAnzeigen();