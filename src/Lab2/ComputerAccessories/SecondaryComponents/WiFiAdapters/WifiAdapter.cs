using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards.PCIVersionDir;

namespace Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapters;

public abstract class WifiAdapter
{
    public abstract string Name { get; }
    public abstract int Version { get; }
    public abstract bool Bluetooth { get; }
    public abstract PCIVersions WifiPciVersions { get; }
    public abstract int WifiAdapterPower { get; }
}