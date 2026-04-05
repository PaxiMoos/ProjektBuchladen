using Logistik;
using Logistik.BenutzerEingaben;
using System;

Console.Clear();

Lager lager = new Lager();
var neuesProdukt = BenutzerEingabe.ProduktAnlegen();

string? produktName = neuesProdukt.produktName;
string? produktMenge = neuesProdukt.produktMenge;

Produkt meinProdukt = new Produkt(produktName, 1001, produktMenge);

lager.WareEinlagern(meinProdukt, produktMenge);

Console.Read();
