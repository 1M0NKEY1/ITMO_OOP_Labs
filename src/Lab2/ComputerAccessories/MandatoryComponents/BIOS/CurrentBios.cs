namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.BIOS;

public class CurrentBios : Bios
{
    private readonly int _biosType;
    private readonly int _biosVersion;

    public CurrentBios(int biosType, int biosVersion)
    {
        _biosType = biosType;
        _biosVersion = biosVersion;
    }

    public override int BiosType => _biosType;
    public override int BiosVersion => _biosVersion;
}