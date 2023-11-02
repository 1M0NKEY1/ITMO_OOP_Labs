using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.SocketType.OnlyAmd;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.CoolingSystem;

public class CoolingSystemFactoryAmd : CoolingSystemsFactoryBase
{
    private string? _name;
    private int _coolingDimension;
    private int _coolingTDP;
    private AmdSocketType? _amdSocketType;

    public void NewInstance(string? name, int coolingDimension, int coolingTDP, AmdSocketType? amdSocketType)
    {
        _name = name;
        _coolingDimension = coolingDimension;
        _coolingTDP = coolingTDP;
        _amdSocketType = amdSocketType;
    }

    public override CoolingSystemsBase Create()
    {
        return new CoolingSystemAmd(_name, _coolingDimension, _coolingTDP, _amdSocketType);
    }
}