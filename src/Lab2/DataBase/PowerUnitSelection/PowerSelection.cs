using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.PowerUnit.Factory;

namespace Itmo.ObjectOrientedProgramming.Lab2.DataBase.PowerUnitSelection;

public class PowerSelection
{
    private const string NameCouger = "Cougar VTE X2 750";
    private const int PowerLimitsCouger = 750;

    private const string NameExeGate = "ExeGate UN850";
    private const int PowerLimitsExeGate = 850;

    private List<PowerUnitFactory> powerUnits = new();

    public PowerSelection()
    {
        powerUnits.Add(new CurrentPowerUnitFactory(
            NameCouger,
            PowerLimitsCouger));

        powerUnits.Add(new CurrentPowerUnitFactory(
            NameExeGate,
            PowerLimitsExeGate));
    }
}