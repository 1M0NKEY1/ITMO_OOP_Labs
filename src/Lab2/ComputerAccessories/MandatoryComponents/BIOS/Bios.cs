using Itmo.ObjectOrientedProgramming.Lab2.Prototype;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.BIOS;

public class Bios : BiosBase, IPrototype<Bios>
{
    private int _biosType;
    private int _biosVersion;
    private string _name;

    public Bios(string name, int biosType, int biosVersion)
    {
        _name = name;
        _biosType = biosType;
        _biosVersion = biosVersion;
    }

    public override string Name => _name;
    public override int BiosType => _biosType;
    public override int BiosVersion => _biosVersion;
    public Bios Clone()
    {
        return new Bios(_name, _biosType, _biosVersion);
    }

    public Bios CloneWithNewName(string name)
    {
        Bios cloneBios = Clone();
        _name = name;

        return cloneBios;
    }

    public Bios CloneWithNewBiosType(int biosType)
    {
        Bios cloneBios = Clone();
        _biosType = biosType;

        return cloneBios;
    }

    public Bios CloneWithNewBiosVersion(int biosVersion)
    {
        Bios cloneBios = Clone();
        _biosVersion = biosVersion;

        return cloneBios;
    }
}