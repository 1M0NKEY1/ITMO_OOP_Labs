using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.SSDs.Factory;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.SSDs.InputTypeDir;

namespace Itmo.ObjectOrientedProgramming.Lab2.DataBase.SSDSelection;

public class SsdSelection
{
    private const string NameKingston = "KINGSTON mSATA SSD SKC600";
    private const int MemoryKingston = 512;
    private const int SpeedKingston = 550;
    private const int PowerKingston = 10;

    private const string NameNetac = "Netac 1 ТБ M.2 NT01NV7000-1T0-E4X";
    private const int MemoryNetac = 1024;
    private const int SpeedNetac = 7200;
    private const int PowerNetac = 25;

    private List<SSDFactory> ssd = new();

    public SsdSelection()
    {
        ssd.Add(new CurrentSSDFactory(
            NameKingston,
            new TypeSata(),
            MemoryKingston,
            SpeedKingston,
            PowerKingston));

        ssd.Add(new CurrentSSDFactory(
            NameNetac,
            new TypePCIE(),
            MemoryNetac,
            SpeedNetac,
            PowerNetac));
    }
}