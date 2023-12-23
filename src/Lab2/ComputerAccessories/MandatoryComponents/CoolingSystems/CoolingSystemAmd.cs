using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.SocketType.OnlyAmd;
using Itmo.ObjectOrientedProgramming.Lab2.Prototype;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.CoolingSystem;

public class CoolingSystemAmd : CoolingSystemsBase, IPrototype<CoolingSystemAmd>
{
    private int _coolingDimension;
    private int _coolingTDP;
    private AmdSocketType? _amdSocketType;
    private string? _name;

    public CoolingSystemAmd(string? name, int coolingDimension, int coolingTDP, AmdSocketType? amdSocketType)
    {
        _name = name;
        _coolingDimension = coolingDimension;
        _coolingTDP = coolingTDP;
        _amdSocketType = amdSocketType;
    }

    public override string? Name => _name;
    public override int CoolingDimensions => _coolingDimension;
    public override int CoolingTDP => _coolingTDP;
    public CoolingSystemAmd Clone()
    {
        return new CoolingSystemAmd(_name, _coolingDimension, _coolingTDP, _amdSocketType);
    }

    public CoolingSystemAmd CloneWithNewName(string? name)
    {
        CoolingSystemAmd cloneCoolingSystem = Clone();
        _name = name;

        return cloneCoolingSystem;
    }

    public CoolingSystemAmd CloneWithNewCoolingDimensions(int dimensions)
    {
        CoolingSystemAmd cloneCoolingSystem = Clone();
        _coolingDimension = dimensions;

        return cloneCoolingSystem;
    }

    public CoolingSystemAmd CloneWithNewCoolingTdp(int tdp)
    {
        CoolingSystemAmd cloneCoolingSystem = Clone();
        _coolingTDP = tdp;

        return cloneCoolingSystem;
    }

    public CoolingSystemAmd CloneWithNewCoolingSocket(AmdSocketType? socketType)
    {
        CoolingSystemAmd cloneCoolingSystem = Clone();
        _amdSocketType = socketType;

        return cloneCoolingSystem;
    }
}