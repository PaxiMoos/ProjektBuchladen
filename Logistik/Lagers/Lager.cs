using System;
using Logistik.Lagers;
using Logistik.Produkte;

namespace Logistik;

public class Lager
{
    public List<WareAllgemein> lagerWare = new List<WareAllgemein>();

    public int Kapzität { get; set; } = 100;
    public int Bestand { get; set; } = 0;
    public int BestandNachWarenEingan { get; set; } = 0;
    LagerPlatz lagerPlatzBananen { get; set; }
    LagerPlatz lagerPlatzÄpfel { get; set; }

    public Lager()
    {

    }
}

