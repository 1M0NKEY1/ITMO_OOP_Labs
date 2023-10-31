using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.SocketTypeDir;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.SocketType.OnlyAmd;

public class AM5 : AmdSocketType
{
    public override bool EqualsOfSockets(SocketTypes? other) => other is AM5;
}