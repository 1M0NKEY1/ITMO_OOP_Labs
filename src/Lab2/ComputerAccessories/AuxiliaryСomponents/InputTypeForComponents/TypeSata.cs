namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.SSDs.InputTypeDir;

public class TypeSata : InputTypes
{
    public override bool EqualsForInputTypes(InputTypes? other) => other is TypeSata;
}