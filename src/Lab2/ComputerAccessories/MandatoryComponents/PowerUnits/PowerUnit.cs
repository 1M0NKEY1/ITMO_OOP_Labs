using Itmo.ObjectOrientedProgramming.Lab2.Computer.RAM;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.SSDs;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards;
using Itmo.ObjectOrientedProgramming.Lab2.Prototype;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapters;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.PowerUnit;

public class PowerUnit : PowerUnitBase, IPrototype<PowerUnit>
{
    private int _highPowerLimits;
    private string? _name;

    public PowerUnit(string? name, int highPowerLimits)
    {
        _name = name;
        _highPowerLimits = highPowerLimits;
    }

    public override string? Name => _name;
    public override int HighPowerLimits => _highPowerLimits;

    public override bool EnoughPower(
        CPU.CpuBase cpuBase,
        RamBase ramBase,
        SSDBase ssdBase,
        VideoCardBase videoCardBase,
        WifiAdapterBase wifiAdapterBase)
    {
        return cpuBase.PowerConsumption + ramBase.RamPower + ssdBase.SSDPower + videoCardBase.VideoCardPower +
            wifiAdapterBase.WifiAdapterPower < _highPowerLimits;
    }

    public PowerUnit Clone()
    {
        return new PowerUnit(_name, _highPowerLimits);
    }

    public PowerUnit CloneWithNewName(string? name)
    {
        PowerUnit clonePowerUnit = Clone();
        _name = name;

        return clonePowerUnit;
    }

    public PowerUnit CloneWithNewPowerLimits(int power)
    {
        PowerUnit clonePowerUnit = Clone();
        _highPowerLimits = power;

        return clonePowerUnit;
    }
}