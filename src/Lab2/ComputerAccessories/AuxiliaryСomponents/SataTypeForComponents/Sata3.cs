namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.SataTypeDir;

public class Sata3 : SataType
{
    public override bool EqualsForSata(SataType? other) => other is Sata3;
}