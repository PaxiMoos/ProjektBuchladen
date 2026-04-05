using System;
using Logistik.Lagers;
using Logistik.Produkte;

namespace Logistik;

public class Lager
{
    public List<WareAllgemein> lagerWare = new List<WareAllgemein>();
    private LagerAuslastung lagerAuslastung = new LagerAuslastung();
    public int BestandNachWarenEingan { get; set; } = 0;
    private LagerPlatz? lagerPlatzBananen { get; set; }
    private LagerPlatz? lagerPlatzÄpfel { get; set; }    
}

