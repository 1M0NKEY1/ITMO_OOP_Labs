using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.SocketType;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.SocketType.OnlyAmd;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.CoolingSystem;

public abstract class CoolingSystems : IComponent
{
    public abstract string Name { get; }
    public abstract int CoolingDimensions { get; }
    public abstract int CoolingTDP { get; }
    public IntelSocketType? IntelCoolingSocket { get; set; }
    public AmdSocketType? AmdCoolingSocket { get; set; }
}