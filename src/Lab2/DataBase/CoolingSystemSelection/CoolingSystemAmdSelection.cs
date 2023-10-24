using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.CoolingSystem;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.SocketType.OnlyAmd;

namespace Itmo.ObjectOrientedProgramming.Lab2.DataBase.CoolingSystemSelection;

public class CoolingSystemAmdSelection
{
    private const string NameDeep = "DEEPCOOL GAMMAXX 400K";
    private const int CoolingDimensionsDeep = 155;
    private const int CoolingTdpDeep = 180;

    private const string NameSe = "ID-Cooling SE-207-TRX BLACK";
    private const int CoolingDimensionsSe = 157;
    private const int CoolingTdpSe = 280;

    private List<CoolingSystemFactoryAmd> coolingSystem = new();

    public CoolingSystemAmdSelection()
    {
        coolingSystem.Add(new CoolingSystemFactoryAmd(
            NameDeep,
            CoolingDimensionsDeep,
            CoolingTdpDeep,
            new AMFive()));

        coolingSystem.Add(new CoolingSystemFactoryAmd(
            NameSe,
            CoolingDimensionsSe,
            CoolingTdpSe,
            new WRXEight()));
    }
}