using Itmo.ObjectOrientedProgramming.Lab2.Computer.CoolingSystem;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.Motherboards;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.ComputerCase;

public abstract class ComputerCasesBase : IComponent
{
    public abstract string? Name { get; }
    public abstract int VideoCardLength { get;  }
    public abstract int VideoCardWidth { get; }
    public abstract int MotherboardFormFactor { get; }
    public abstract int CaseDimensions { get; }
    public abstract bool AvailableMotherBoardForCase(MotherBoardBase motherBoardBase);
    public abstract bool AvailableCoolingSystemForCase(CoolingSystemsBase coolingSystemsBase);
}