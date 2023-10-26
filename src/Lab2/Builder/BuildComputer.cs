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
        if (Checker() && CheckPower())
        {
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

        return null;
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

    private bool Checker()
    {
        if (_computerCases is null) return false;
        if (_motherBoard is null) return false;
        if (_cpu is null) return false;
        if (_wifiAdapter is null) return false;
        return _computerCases.AvailableCoolingSystemForCase(
                   _coolingSystems ?? throw new CreateBuilderNullException(nameof(_coolingSystems)))
               && _computerCases.AvailableMotherBoardForCase(_motherBoard)
               && _cpu.AvailableMotherboardForCpu(_motherBoard)
               && _cpu.EnoughTdpCoolingSystem(_coolingSystems)
               && _motherBoard.AvailableRamForMotherboard(_ram ?? throw new CreateBuilderNullException(nameof(_ram)))
               && _wifiAdapter.AvailablePCE(_motherBoard);
    }

    private bool CheckPower()
    {
        if (_cpu is null) return false;
        if (_wifiAdapter is null) return false;
        if (_ram is null) return false;
        if (_ssd is null) return false;
        if (_videoCard is null) return false;
        if (_powerUnit is null) return false;

        return _powerUnit.EnoughPower(_cpu, _ram, _ssd, _videoCard, _wifiAdapter);
    }
}