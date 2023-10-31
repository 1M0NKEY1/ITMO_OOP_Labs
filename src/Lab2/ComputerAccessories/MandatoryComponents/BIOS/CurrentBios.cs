using Itmo.ObjectOrientedProgramming.Lab2.Prototype;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.BIOS;

public class CurrentBios : Bios, IPrototype<CurrentBios>
{
    private int _biosType;
    private int _biosVersion;
    private string _name;

    public CurrentBios(string name, int biosType, int biosVersion)
    {
        _name = name;
        _biosType = biosType;
        _biosVersion = biosVersion;
    }

    public override string Name => _name;
    public override int BiosType => _biosType;
    public override int BiosVersion => _biosVersion;
    public CurrentBios Clone()
    {
        return new CurrentBios(_name, _biosType, _biosVersion);
    }

    public CurrentBios SetName(string name)
    {
        CurrentBios cloneBios = Clone();
        _name = name;

        return cloneBios;
    }

    public CurrentBios SetBiosType(int biosType)
    {
        CurrentBios cloneBios = Clone();
        _biosType = biosType;

        return cloneBios;
    }

    public CurrentBios SetBiosVersion(int biosVersion)
    {
        CurrentBios cloneBios = Clone();
        _biosVersion = biosVersion;

        return cloneBios;
    }
}