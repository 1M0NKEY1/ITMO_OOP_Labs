namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

public class EngineE : SelectEngine
{
    private int EngE { get; set; }

    public override void SetNumOfEngine()
    {
        EngE = 2;
    }

    public override int GetNumOfEngine()
    {
        SetNumOfEngine();
        return EngE;
    }
}