using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.SocketType.OnlyAmd;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.CoolingSystem;

public class CoolingSystemAmd : CoolingSystems
{
    private readonly string _name;
    private readonly int _coolingDimension;
    private readonly int _coolingTDP;

    public CoolingSystemAmd(string name, int coolingDimension, int coolingTDP, AmdSocketType amdSocketType)
    {
        _name = name;
        _coolingDimension = coolingDimension;
        _coolingTDP = coolingTDP;
        AmdCoolingSocket = amdSocketType;
    }

    public override string Name => _name;
    public override int CoolingDimensions => _coolingDimension;
    public override int CoolingTDP => _coolingTDP;
}