using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.SocketType;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.CoolingSystem;

public class CoolingSystemFactoryIntel : CoolingSystemsFactoryBase
{
    private string? _name;
    private int _coolingDimension;
    private int _coolingTDP;
    private IntelSocketType? _intelSocketType;

    public void NewInstance(
        string? name,
        int coolingDimension,
        int coolingTDP,
        IntelSocketType? intelSocketType)
    {
        _name = name;
        _coolingDimension = coolingDimension;
        _coolingTDP = coolingTDP;
        _intelSocketType = intelSocketType;
    }

    public override CoolingSystemsBase Create()
    {
        return new CoolingSystemIntel(_name, _coolingDimension, _coolingTDP, _intelSocketType);
    }
}