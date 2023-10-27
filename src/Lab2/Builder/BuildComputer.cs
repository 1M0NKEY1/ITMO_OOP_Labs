using Itmo.ObjectOrientedProgramming.Lab2.Computer.ComputerCase;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.CoolingSystem;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.PowerUnit;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.RAM;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.Motherboards;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.SSDs;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapters;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.Builder;

public class BuildComputer : IBuilder
{
    private ComputerCases? _computerCases;
    private CoolingSystems? _coolingSystems;
    private Cpu? _cpu;
    private MotherBoard? _motherBoard;
    private PowerUnit? _powerUnit;
    private Ram? _ram;
    private SSD? _ssd;
    private VideoCard? _videoCard;
    private WifiAdapter? _wifiAdapter;

    public Computer? Create()
    {
        if (!CheckPower()) throw new CreateBuilderNullException("Power");
        if (!CheckCoolingSystemSize()) throw new CreateBuilderNullException("Size");
        if (!CheckCoolingSystemTdp()) throw new CreateBuilderNullException("Tdp");
        if (!CheckRamFormFactor()) throw new CreateBuilderNullException("RamFormFactor");
        if (!CheckSocketTypeCpu()) throw new CreateBuilderNullException("Socket");
        if (!CheckFormFactorMotherBoard()) throw new CreateBuilderNullException("MotherFormFactor");
        if (!CheckWifiPci()) throw new CreateBuilderNullException("Wifi Pci");

        return new Computer(
            _computerCases ?? throw new CreateBuilderNullException(nameof(_computerCases)),
            _coolingSystems ?? throw new CreateBuilderNullException(nameof(_coolingSystems)),
            _cpu ?? throw new CreateBuilderNullException(nameof(_cpu)),
            _motherBoard ?? throw new CreateBuilderNullException(nameof(_motherBoard)),
            _powerUnit ?? throw new CreateBuilderNullException(nameof(_powerUnit)),
            _ram ?? throw new CreateBuilderNullException(nameof(_ram)),
            _ssd,
            _videoCard,
            _wifiAdapter);
    }

    public IBuilder WithComputerCase(ComputerCases computerCases)
    {
        _computerCases = computerCases;
        return this;
    }

    public IBuilder WithCoolingSystem(CoolingSystems coolingSystems)
    {
        _coolingSystems = coolingSystems;
        return this;
    }

    public IBuilder WithCpu(Cpu cpu)
    {
        _cpu = cpu;
        return this;
    }

    public IBuilder WithMotherboard(MotherBoard motherBoard)
    {
        _motherBoard = motherBoard;
        return this;
    }

    public IBuilder WithPowerUnit(PowerUnit powerUnit)
    {
        _powerUnit = powerUnit;
        return this;
    }

    public IBuilder WithRam(Ram ram)
    {
        _ram = ram;
        return this;
    }

    public IBuilder WithSsd(SSD ssd)
    {
        _ssd = ssd;
        return this;
    }

    public IBuilder WithVideoCard(VideoCard videoCard)
    {
        _videoCard = videoCard;
        return this;
    }

    public IBuilder WithWifiAdapter(WifiAdapter wifiAdapter)
    {
        _wifiAdapter = wifiAdapter;
        return this;
    }

    private bool CheckRamFormFactor()
    {
        return _motherBoard is not null
               && _motherBoard.AvailableRamForMotherboard(_ram ?? throw new CreateBuilderNullException(nameof(_ram)));
    }

    private bool CheckFormFactorMotherBoard()
    {
        if (_computerCases is null) return false;
        return _motherBoard is not null && _computerCases.AvailableMotherBoardForCase(_motherBoard);
    }

    private bool CheckSocketTypeCpu()
    {
        if (_motherBoard is null) return false;
        return _cpu is not null && _cpu.AvailableMotherboardForCpu(_motherBoard);
    }

    private bool CheckCoolingSystemSize()
    {
        if (_computerCases is null) return false;
        return _computerCases.AvailableCoolingSystemForCase(
            _coolingSystems ?? throw new CreateBuilderNullException(nameof(_coolingSystems)));
    }

    private bool CheckCoolingSystemTdp()
    {
        if (_coolingSystems is null) return false;
        return _cpu is not null && _cpu.EnoughTdpCoolingSystem(_coolingSystems);
    }

    private bool CheckPower()
    {
        if (_cpu is null) return false;
        if (_wifiAdapter is null) return false;
        if (_ram is null) return false;
        if (_ssd is null) return false;
        if (_videoCard is null) return false;
        return _powerUnit is not null && _powerUnit.EnoughPower(_cpu, _ram, _ssd, _videoCard, _wifiAdapter);
    }

    private bool CheckIntegratedGraphic()
    {
        return _cpu is not null && _cpu.IntegratedGraphics;
    }

    private bool CheckWifiPci()
    {
        if (_wifiAdapter is null) return false;
        return _motherBoard is not null && _wifiAdapter.AvailablePcie(_motherBoard);
    }
}