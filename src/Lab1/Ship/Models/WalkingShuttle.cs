using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Models;

public class WalkingShuttle : StarShip
{
    private HullClassOne _hullClassOne = new HullClassOne();

    public WalkingShuttle(bool emitter, bool photonDeflector)
    {
        Crew = true;
        Emitter = emitter;
        PhotonDeflector = photonDeflector;
        ClassOfDeflectors = 0;
        ClassOfEngine = (int)SelectEngine.TypeEngineC;
        ClassOfHull = (int)SelectHull.HullClassOne;
        Size = (int)SelectSize.Small;
        ClassOfJumpEngine = 0;
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