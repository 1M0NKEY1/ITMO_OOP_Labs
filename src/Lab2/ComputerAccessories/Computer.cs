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
    private readonly ComputerCases _computerCases;
    private readonly CoolingSystems _coolingSystems;
    private readonly Cpu _cpu;
    private readonly MotherBoard _motherBoard;
    private readonly PowerUnit _powerUnit;
    private readonly Ram _ram;
    private readonly SSD? _ssd;
    private readonly VideoCard? _videoCard;
    private readonly WifiAdapter? _wifiAdapter;

    public Computer(
        ComputerCases computerCases,
        CoolingSystems coolingSystems,
        Cpu cpu,
        MotherBoard motherBoard,
        PowerUnit powerUnit,
        Ram ram,
        SSD? ssd,
        VideoCard? videoCard,
        WifiAdapter? wifiAdapter)
    {
        _computerCases = computerCases;
        _coolingSystems = coolingSystems;
        _cpu = cpu;
        _motherBoard = motherBoard;
        _powerUnit = powerUnit;
        _ram = ram;
        _ssd = ssd;
        _videoCard = videoCard;
        _wifiAdapter = wifiAdapter;
    }
}