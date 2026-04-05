using System;
using Logistik.Lagers;
using Logistik.Produkte;

namespace Logistik;

public class Lager
{
    public List<WareAllgemein> lagerWare = new List<WareAllgemein>();
    public LagerAuslastung lagerAuslastung = new LagerAuslastung();
    public LagerPlatz? lagerPlatzBananen = new LagerPlatz("'Bananen'");
    public LagerPlatz? lagerPlatzÄpfel = new LagerPlatz("'Äpfel'");
}

