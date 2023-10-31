namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.BIOS;

public abstract class Bios
{
    public abstract string Name { get; }
    public abstract int BiosType { get; }
    public abstract int BiosVersion { get; }
}