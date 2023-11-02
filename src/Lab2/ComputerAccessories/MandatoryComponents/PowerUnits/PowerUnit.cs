using Itmo.ObjectOrientedProgramming.Lab2.Computer.RAM;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.SSDs;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapters;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.PowerUnit;

public abstract class PowerUnit : IComponent
{
    public abstract string? Name { get; }
    public abstract int HighPowerLimits { get; }

    public abstract bool EnoughPower(
        CPU.Cpu cpu,
        Ram ram,
        SSD ssd,
        VideoCard videoCard,
        WifiAdapter wifiAdapter);
}