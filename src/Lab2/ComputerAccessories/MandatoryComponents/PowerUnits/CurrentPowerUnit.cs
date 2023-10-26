using Itmo.ObjectOrientedProgramming.Lab2.Computer.RAM;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.SSDs;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapters;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.PowerUnit;

public class CurrentPowerUnit : PowerUnit
{
    private readonly string _name;
    private readonly int _highPowerLimits;

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
}