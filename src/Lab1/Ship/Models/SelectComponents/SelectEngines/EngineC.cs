namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

public class EngineC : SelectEngine
{
    private int EngC { get; set; }

    public override void SetNumOfEngine()
    {
        EngC = 1;
    }

    public override int GetNumOfEngine()
    {
        SetNumOfEngine();
        return EngC;
    }
}