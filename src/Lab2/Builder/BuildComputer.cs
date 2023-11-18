using System.Collections.Generic;
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
    private IList<ComputerBuildResult> _criticalResultList = new List<ComputerBuildResult>();
    private IList<ComputerBuildResult> _nonCriticalResultList = new List<ComputerBuildResult>();

    private ComputerCasesBase? _computerCases;
    private CoolingSystemsBase? _coolingSystems;
    private CpuBase? _cpu;
    private MotherBoardBase? _motherBoard;
    private PowerUnitBase? _powerUnit;
    private RamBase? _ram;
    private SSDBase? _ssd;
    private VideoCardBase? _videoCard;
    private WifiAdapterBase? _wifiAdapter;

    public Computer Create()
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

    public IBuilder WithComputerCase(ComputerCasesBase computerCasesBase)
    {
        _computerCases = computerCasesBase;
        return this;
    }

    public IBuilder WithCoolingSystem(CoolingSystemsBase coolingSystemsBase)
    {
        _coolingSystems = coolingSystemsBase;
        return this;
    }

    public IBuilder WithCpu(CpuBase cpuBase)
    {
        _cpu = cpuBase;
        return this;
    }

    public IBuilder WithMotherboard(MotherBoardBase motherBoardBase)
    {
        _motherBoard = motherBoardBase;
        return this;
    }

    public IBuilder WithPowerUnit(PowerUnitBase powerUnitBase)
    {
        _powerUnit = powerUnitBase;
        return this;
    }

    public IBuilder WithRam(RamBase ramBase)
    {
        _ram = ramBase;
        return this;
    }

    public IBuilder WithSsd(SSDBase ssdBase)
    {
        _ssd = ssdBase;
        return this;
    }

    public IBuilder WithVideoCard(VideoCardBase videoCardBase)
    {
        _videoCard = videoCardBase;
        return this;
    }

    public IBuilder WithWifiAdapter(WifiAdapterBase wifiAdapterBase)
    {
        _wifiAdapter = wifiAdapterBase;
        return this;
    }

    public IList<ComputerBuildResult> GetResultMessage()
    {
        var message = new List<ComputerBuildResult>();

        CriticalErrorCheck();
        SecondaryErrorCheck();

        if (_criticalResultList.Count > 0)
        {
            message.AddRange(_criticalResultList);

            return message;
        }

        if (_nonCriticalResultList.Count > 0)
        {
            message.Add(ComputerBuildResult.Success);
            message.AddRange(_nonCriticalResultList);

            return message;
        }

        message.Add(ComputerBuildResult.Success);

        return message;
    }

    private void CriticalErrorCheck()
    {
        if (!CheckCoolingSystemSize()) _criticalResultList.Add(ComputerBuildResult.OutOfSize);
        if (!CheckRamFormFactor()) _criticalResultList.Add(ComputerBuildResult.OutOfSize);
        if (!CheckSocketTypeCpu()) _criticalResultList.Add(ComputerBuildResult.WrongSocket);
        if (!CheckFormFactorMotherBoard()) _criticalResultList.Add(ComputerBuildResult.OutOfSize);
        if (!CheckWifiPci()) _criticalResultList.Add(ComputerBuildResult.WrongPcie);
    }

    private void SecondaryErrorCheck()
    {
        if (!CheckPower()) _nonCriticalResultList.Add(ComputerBuildResult.CriticalPower);
        if (!CheckCoolingSystemTdp()) _nonCriticalResultList.Add(ComputerBuildResult.CriticalTdp);
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