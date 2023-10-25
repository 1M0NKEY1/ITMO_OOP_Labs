using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards.PCIVersionDir;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapters;

namespace Itmo.ObjectOrientedProgramming.Lab2.DataBase.WIFIAdapterSelection;

public class WifiAdapterSelection
{
    private const string NameLtx = "USB LTX-W04 3dBi";
    private const int VersionLtx = 4;
    private const bool BluetoothLtx = false;
    private const int AdapterPowerLtx = 5;

    private const string NameMercus = "Mercusys MW150US";
    private const int VersionMercus = 3;
    private const bool BluetoothMercus = true;
    private const int AdapterPowerMercus = 5;

    private List<WifiAdapter> wifiAdapters = new();

    public WifiAdapterSelection()
    {
        wifiAdapters.Add(new CurrentWifiAdapter(
            NameLtx,
            VersionLtx,
            BluetoothLtx,
            new PCIE3(),
            AdapterPowerLtx));

        wifiAdapters.Add(new CurrentWifiAdapter(
            NameMercus,
            VersionMercus,
            BluetoothMercus,
            new PCIE4(),
            AdapterPowerMercus));
    }
}