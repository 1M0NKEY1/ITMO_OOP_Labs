using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.Motherboards;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards.PCIVersionDir;
using Itmo.ObjectOrientedProgramming.Lab2.Prototype;

namespace Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapters;

public class WifiAdapter : WifiAdapterBase, IPrototype<WifiAdapter>
{
    private int _version;
    private bool _bluetooth;
    private PCIVersions _wifiPciVersion;
    private int _wifiAdapterPower;
    private string? _name;

    public WifiAdapter(
        string? name,
        int version,
        bool bluetooth,
        PCIVersions pciVersions,
        int wifiAdapterPower)
    {
        _name = name;
        _version = version;
        _bluetooth = bluetooth;
        _wifiPciVersion = pciVersions;
        _wifiAdapterPower = wifiAdapterPower;
    }

    public override string? Name => _name;
    public override int Version => _version;
    public override bool Bluetooth => _bluetooth;
    public override PCIVersions WifiPciVersions => _wifiPciVersion;
    public override int WifiAdapterPower => _wifiAdapterPower;
    public override bool AvailablePcie(MotherBoardBase motherBoardBase)
    {
        return motherBoardBase.Pci != null && motherBoardBase.Pci.EqualsForPciVersions(_wifiPciVersion);
    }

    public WifiAdapter Clone()
    {
        return new WifiAdapter(
        _name,
        _version,
        _bluetooth,
        _wifiPciVersion,
        _wifiAdapterPower);
    }

    public WifiAdapter CloneWithNewName(string? name)
    {
        WifiAdapter cloneWifi = Clone();
        _name = name;

        return cloneWifi;
    }

    public WifiAdapter CloneWithNewVersion(int version)
    {
        WifiAdapter cloneWifi = Clone();
        _version = version;

        return cloneWifi;
    }

    public WifiAdapter CloneWithNewBluetooth(bool bluetooth)
    {
        WifiAdapter cloneWifi = Clone();
        _bluetooth = bluetooth;

        return cloneWifi;
    }

    public WifiAdapter CloneWithNewPci(PCIVersions pciVersions)
    {
        WifiAdapter cloneWifi = Clone();
        _wifiPciVersion = pciVersions;

        return cloneWifi;
    }

    public WifiAdapter CloneWithNewPower(int power)
    {
        WifiAdapter cloneWifi = Clone();
        _wifiAdapterPower = power;

        return cloneWifi;
    }
}