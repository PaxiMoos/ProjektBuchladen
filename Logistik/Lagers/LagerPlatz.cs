using System;

namespace Logistik.Lagers;

public class LagerPlatz
{
    public string? Name { get; set; }

    public LagerPlatz(string name)
    {
        Name = name;
    }
}
