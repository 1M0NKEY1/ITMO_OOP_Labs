using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines.TypeJump;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments;

public class SuperFog : Environment
{
    private readonly IList<object> _obstacles = new List<object>();

    public SuperFog(IList<Obstacles> classOfObstacle)
    {
        foreach (Obstacles obstacle in classOfObstacle)
        {
            if (obstacle is SuperFogObstacles)
            {
                _obstacles.Add(obstacle);
            }
        }
    }

    public override bool Stage(StarShip? ship, int astronomicUnits)
    {
        if (ship == null) return false;

        if (ship.ClassOfJumpEngine is not TypeJumpEngineAlpha or TypeJumpEngineOmega or TypeJumpEngineGamma)
        {
            return false;
        }

        if (!ship.Photon) return false;

        ship.ClassOfJumpEngine.Duration(astronomicUnits);
        if (ship.ClassOfJumpEngine is { TooFar: true }) return false;

        ship.ClassOfDeflectors?.Damage(_obstacles.Count, _obstacles);

        return ship.ClassOfDeflectors is not { PhotonDeflectorDefencePoint: < 0 };
    }
}