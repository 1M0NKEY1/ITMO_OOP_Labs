using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.CoolingSystem;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.SocketType;

namespace Itmo.ObjectOrientedProgramming.Lab2.DataBase.CoolingSystemSelection;

public class CoolingSystemIntelSelection
{
    private const string NameJons = "JONSBO CR-1400 EVO";
    private const int CoolingDimensionsJons = 130;
    private const int CoolingTdpJons = 180;

    private const string NameNoctua = "Noctua NH-D15";
    private const int CoolingDimensionsNoctua = 165;
    private const int CoolingTdpNoctua = 220;

    private List<CoolingSystemsFactory> coolingSystem = new();

    public CoolingSystemIntelSelection()
    {
        coolingSystem.Add(new CoolingSystemFactoryIntel(
            NameJons,
            CoolingDimensionsJons,
            CoolingTdpJons,
            new LGAOneOneFiveOne()));

        coolingSystem.Add(new CoolingSystemFactoryIntel(
            NameNoctua,
            CoolingDimensionsNoctua,
            CoolingTdpNoctua,
            new LGATwoZeroSixSix()));
    }
}