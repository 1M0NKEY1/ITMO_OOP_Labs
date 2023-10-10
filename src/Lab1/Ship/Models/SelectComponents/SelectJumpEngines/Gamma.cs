namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

public class Gamma : SelectJumpEngine
{
    private int TypeGamma { get; set; }

    public override void SetNumOfJumpEngine()
    {
        TypeGamma = 3;
    }

    public override int GetNumOfJumpEngine()
    {
        SetNumOfJumpEngine();
        return TypeGamma;
    }
}