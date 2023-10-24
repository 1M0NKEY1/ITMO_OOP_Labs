using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.SocketType;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.CoolingSystem;

public class CoolingSystemIntel : CoolingSystems
{
    private readonly string _name;
    private readonly int _coolingDimension;
    private readonly int _coolingTDP;

    public CoolingSystemIntel(string name, int coolingDimension, int coolingTDP, IntelSocketType intelSocketType)
    {
        _name = name;
        _coolingDimension = coolingDimension;
        _coolingTDP = coolingTDP;
        IntelCoolingSocket = intelSocketType;
    }

    public override string Name => _name;
    public override int CoolingDimensions => _coolingDimension;
    public override int CoolingTDP => _coolingTDP;
}