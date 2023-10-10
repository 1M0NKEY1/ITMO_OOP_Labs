namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

public class Omega : SelectJumpEngine
{
    private int TypeOmega { get; set; }

    public override void SetNumOfJumpEngine()
    {
        TypeOmega = 2;
    }

    public override int GetNumOfJumpEngine()
    {
        SetNumOfJumpEngine();
        return TypeOmega;
    }
}