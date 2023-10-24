namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.ComputerCase;

public abstract class ComputerCases
{
    public abstract string Name { get; }
    public abstract int VideoCardLength { get;  }
    public abstract int VideoCardWidth { get; }
    public abstract int MotherboardFormFactor { get; }
    public abstract int CaseDimensions { get; }
}