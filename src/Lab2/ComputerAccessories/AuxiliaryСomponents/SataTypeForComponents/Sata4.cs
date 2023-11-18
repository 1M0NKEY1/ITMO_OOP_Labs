namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.SataTypeDir;

public class Sata4 : SataType
{
    public override bool EqualsForSata(SataType? other) => other is Sata4;
}