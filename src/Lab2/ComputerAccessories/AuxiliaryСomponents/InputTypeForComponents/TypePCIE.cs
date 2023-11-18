namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.SSDs.InputTypeDir;

public class TypePCIE : InputTypes
{
    public override bool EqualsForInputTypes(InputTypes? other) => other is TypePCIE;
}