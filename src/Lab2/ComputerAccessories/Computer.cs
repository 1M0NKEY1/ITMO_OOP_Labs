using Itmo.ObjectOrientedProgramming.Lab2.Computer.ComputerCase;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.CoolingSystem;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.PowerUnit;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.RAM;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.Motherboards;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.SSDs;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapters;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories;

public class Computer
{
    private readonly ComputerCasesBase _computerCasesBase;
    private readonly CoolingSystemsBase _coolingSystemsBase;
    private readonly CpuBase _cpuBase;
    private readonly MotherBoardBase _motherBoardBase;
    private readonly PowerUnitBase _powerUnitBase;
    private readonly RamBase _ramBase;
    private readonly SSDBase? _ssd;
    private readonly VideoCardBase? _videoCard;
    private readonly WifiAdapterBase? _wifiAdapter;

    public Computer(
        ComputerCasesBase computerCasesBase,
        CoolingSystemsBase coolingSystemsBase,
        CpuBase cpuBase,
        MotherBoardBase motherBoardBase,
        PowerUnitBase powerUnitBase,
        RamBase ramBase,
        SSDBase? ssd,
        VideoCardBase? videoCard,
        WifiAdapterBase? wifiAdapter)
    {
        _computerCasesBase = computerCasesBase;
        _coolingSystemsBase = coolingSystemsBase;
        _cpuBase = cpuBase;
        _motherBoardBase = motherBoardBase;
        _powerUnitBase = powerUnitBase;
        _ramBase = ramBase;
        _ssd = ssd;
        _videoCard = videoCard;
        _wifiAdapter = wifiAdapter;
    }
}