using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.Motherboards;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards.PCIVersionDir;

namespace Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapters;

public class CurrentWifiAdapter : WifiAdapter
{
    private readonly string _name;
    private readonly int _version;
    private readonly bool _bluetooth;
    private readonly PCIVersions _wifiPciVersion;
    private readonly int _wifiAdapterPower;

    public CurrentWifiAdapter(
        string name,
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

    public override string Name => _name;
    public override int Version => _version;
    public override bool Bluetooth => _bluetooth;
    public override PCIVersions WifiPciVersions => _wifiPciVersion;
    public override int WifiAdapterPower => _wifiAdapterPower;
    public override bool AvailablePcie(MotherBoard motherBoard)
    {
        return motherBoard.Pci.Equals(_wifiPciVersion);
    }
}