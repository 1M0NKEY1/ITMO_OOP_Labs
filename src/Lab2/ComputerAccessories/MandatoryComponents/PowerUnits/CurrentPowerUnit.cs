using Itmo.ObjectOrientedProgramming.Lab2.Computer.RAM;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.SSDs;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards;
using Itmo.ObjectOrientedProgramming.Lab2.Prototype;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapters;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.PowerUnit;

public class CurrentPowerUnit : PowerUnit, IPrototype<CurrentPowerUnit>
{
    private int _highPowerLimits;
    private string _name;

    public CurrentPowerUnit(string name, int highPowerLimits)
    {
        _name = name;
        _highPowerLimits = highPowerLimits;
    }

    public override string Name => _name;
    public override int HighPowerLimits => _highPowerLimits;

    public override bool EnoughPower(
        CPU.Cpu cpu,
        Ram ram,
        SSD ssd,
        VideoCard videoCard,
        WifiAdapter wifiAdapter)
    {
        return cpu.PowerConsumption + ram.RamPower + ssd.SSDPower + videoCard.VideoCardPower +
            wifiAdapter.WifiAdapterPower < _highPowerLimits;
    }

    public CurrentPowerUnit Clone()
    {
        return new CurrentPowerUnit(_name, _highPowerLimits);
    }

    public CurrentPowerUnit SetName(string name)
    {
        CurrentPowerUnit clonePowerUnit = Clone();
        _name = name;

        return clonePowerUnit;
    }

    public CurrentPowerUnit SetPowerLimits(int power)
    {
        CurrentPowerUnit clonePowerUnit = Clone();
        _highPowerLimits = power;

        return clonePowerUnit;
    }
}