using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.SocketType;
using Itmo.ObjectOrientedProgramming.Lab2.Prototype;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.CoolingSystem;

public class CoolingSystemIntel : CoolingSystems, IPrototype<CoolingSystemIntel>
{
    private int _coolingDimension;
    private int _coolingTDP;
    private IntelSocketType? _intelSocketType;
    private string? _name;

    public CoolingSystemIntel(string? name, int coolingDimension, int coolingTDP, IntelSocketType? intelSocketType)
    {
        _name = name;
        _coolingDimension = coolingDimension;
        _coolingTDP = coolingTDP;
        _intelSocketType = intelSocketType;
    }

    public override string? Name => _name;
    public override int CoolingDimensions => _coolingDimension;
    public override int CoolingTDP => _coolingTDP;
    public CoolingSystemIntel Clone()
    {
        return new CoolingSystemIntel(_name, _coolingDimension, _coolingTDP, _intelSocketType);
    }

    public CoolingSystemIntel CloneWithNewName(string? name)
    {
        CoolingSystemIntel cloneCoolingSystem = Clone();
        _name = name;

        return cloneCoolingSystem;
    }

    public CoolingSystemIntel CloneWithNewCoolingDimensions(int dimensions)
    {
        CoolingSystemIntel cloneCoolingSystem = Clone();
        _coolingDimension = dimensions;

        return cloneCoolingSystem;
    }

    public CoolingSystemIntel CloneWithNewCoolingTdp(int tdp)
    {
        CoolingSystemIntel cloneCoolingSystem = Clone();
        _coolingTDP = tdp;

        return cloneCoolingSystem;
    }

    public CoolingSystemIntel CloneWithNewCoolingSocket(IntelSocketType? socketType)
    {
        CoolingSystemIntel cloneCoolingSystem = Clone();
        _intelSocketType = socketType;

        return cloneCoolingSystem;
    }
}