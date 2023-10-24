using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.SocketType.OnlyAmd;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.CoolingSystem;

public class CoolingSystemFactoryAmd : CoolingSystemsFactory
{
    private readonly string _name;
    private readonly int _coolingDimension;
    private readonly int _coolingTDP;
    private readonly AmdSocketType _amdSocketType;

    public CoolingSystemFactoryAmd(string name, int coolingDimension, int coolingTDP, AmdSocketType amdSocketType)
    {
        _name = name;
        _coolingDimension = coolingDimension;
        _coolingTDP = coolingTDP;
        _amdSocketType = amdSocketType;
    }

    public override CoolingSystems CreateCoolingSystem()
    {
        return new CoolingSystemAmd(_name, _coolingDimension, _coolingTDP, _amdSocketType);
    }
}