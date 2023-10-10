namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

public class Alpha : SelectJumpEngine
{
    private int TypeAlpha { get; set; }

    public override void SetNumOfJumpEngine()
    {
        TypeAlpha = 1;
    }

    public override int GetNumOfJumpEngine()
    {
        SetNumOfJumpEngine();
        return TypeAlpha;
    }
}