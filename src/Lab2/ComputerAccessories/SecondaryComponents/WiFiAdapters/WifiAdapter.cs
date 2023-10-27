using System;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.Motherboards;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards.PCIVersionDir;

namespace Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapters;

public abstract class WifiAdapter : IComponent, IEquatable<IComponent>
{
    public abstract string Name { get; }
    public abstract int Version { get; }
    public abstract bool Bluetooth { get; }
    public abstract PCIVersions WifiPciVersions { get; }
    public abstract int WifiAdapterPower { get; }

    public abstract bool AvailablePcie(MotherBoard motherBoard);
    public bool Equals(IComponent? other)
    {
        if (other is WifiAdapter otherWifiAdapter)
        {
            return WifiPciVersions.Equals(otherWifiAdapter.WifiPciVersions);
        }

        return false;
    }
}