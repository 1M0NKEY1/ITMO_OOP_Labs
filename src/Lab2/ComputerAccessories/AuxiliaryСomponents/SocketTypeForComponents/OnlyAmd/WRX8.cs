using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.SocketTypeDir;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.SocketType.OnlyAmd;

public class WRX8 : AmdSocketType
{
    public override bool Equals(SocketTypes? other) => other is WRX8;
}