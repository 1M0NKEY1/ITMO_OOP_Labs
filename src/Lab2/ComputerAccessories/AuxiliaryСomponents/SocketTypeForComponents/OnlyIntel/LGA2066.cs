using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.SocketTypeDir;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.SocketType;

public class LGA2066 : IntelSocketType
{
    public override bool Equals(SocketTypes? other) => other is LGA2066;
}