using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories;
using Itmo.ObjectOrientedProgramming.Lab2.XMPProfile;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.RAM;

public abstract class RamBase : IComponent
{
    public abstract string? Name { get; }
    public abstract int MemoryLimits { get; }
    public abstract XmpProfile? AvailableXMP { get; }
    public abstract int RamFormFactor { get; }
    public abstract int VersionDDR { get; }
    public abstract int RamPower { get; }
}