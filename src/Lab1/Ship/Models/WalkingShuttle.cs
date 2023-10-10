using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Models;

public class WalkingShuttle : StarShip
{
    private readonly HullClassOne _hullClassOne = new();
    private readonly HullOne _hullOne = new();

    private readonly EngineC _engineC = new();

    private readonly Small _small = new();

    public WalkingShuttle()
    {
        Crew = true;
        ClassOfDeflectors = 0;
        ClassOfEngine = _engineC.GetNumOfEngine();
        ClassOfHull = _hullOne.GetNumOfHull();
        Size = _small.GetNumOfSize();

        Destroyed = false;
    }

    public override void Destroy()
    {
        if (!_hullClassOne.HullDestroyed) return;
        Crew = false;
        Destroyed = true;
        throw new CustomExceptions("WalkingShuttle destroyed");
    }
}