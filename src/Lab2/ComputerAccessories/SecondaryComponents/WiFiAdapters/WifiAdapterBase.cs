using System;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.Motherboards;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards.PCIVersionDir;

namespace Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapters;

public abstract class WifiAdapterBase : IComponent, IEquatable<IComponent>
{
    public abstract string? Name { get; }
    public abstract int Version { get; }
    public abstract bool Bluetooth { get; }
    public abstract PCIVersions WifiPciVersions { get; }
    public abstract int WifiAdapterPower { get; }

    public abstract bool AvailablePcie(MotherBoardBase motherBoardBase);
    public bool Equals(IComponent? other)
    {
        if (other is WifiAdapterBase otherWifiAdapter)
        {
            return WifiPciVersions.EqualsForPciVersions(otherWifiAdapter.WifiPciVersions);
        }

        return false;
    }
}