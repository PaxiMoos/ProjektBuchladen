using System;

namespace Logistik.Produkte;

public class Banane : WareAllgemein
{
    public Banane(string name, int id, string menge)
    {
        Name = name;
        ID = id;
        Menge = menge;
    }
}
