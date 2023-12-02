using Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Size;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Models;

public class WalkingShuttle : StarShip
{
    private static int _fuel;
    private readonly Hull _hullClassOne = new HullClassOne();
    private readonly Engine _engineC = new TypeEngineC(_fuel);
    private readonly ShipSize _small = new Small();

    public WalkingShuttle(int plasmFuel)
    {
        Crew = true;
        Destroyed = false;
        _fuel = plasmFuel;

        ClassOfHull = _hullClassOne;
        ClassOfEngine = _engineC;
        ClassOfSize = _small;
    }

    public override void Destroy()
    {
        if (!_hullClassOne.HullDestroyed) return;
        Crew = false;
        Destroyed = true;
        throw new CustomExceptions("WalkingShuttle destroyed");
    }
}