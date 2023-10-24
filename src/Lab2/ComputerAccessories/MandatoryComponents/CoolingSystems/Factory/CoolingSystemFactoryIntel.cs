using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.SocketType;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.CoolingSystem;

public class CoolingSystemFactoryIntel : CoolingSystemsFactory
{
    private readonly string _name;
    private readonly int _coolingDimension;
    private readonly int _coolingTDP;
    private readonly IntelSocketType _intelSocketType;

    public CoolingSystemFactoryIntel(string name, int coolingDimension, int coolingTDP, IntelSocketType intelSocketType)
    {
        _name = name;
        _coolingDimension = coolingDimension;
        _coolingTDP = coolingTDP;
        _intelSocketType = intelSocketType;
    }

    public override CoolingSystems CreateCoolingSystem()
    {
        return new CoolingSystemIntel(_name, _coolingDimension, _coolingTDP, _intelSocketType);
    }
}