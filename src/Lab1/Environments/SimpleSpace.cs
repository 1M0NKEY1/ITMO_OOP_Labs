using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments;

public class SimpleSpace : Environment
{
    private readonly IList<object> _obstacles = new List<object>();

    public SimpleSpace(IList<Obstacles> classOfObstacle)
    {
        foreach (Obstacles obstacle in classOfObstacle)
        {
            if (obstacle is SimpleSpaceObstacles)
            {
                _obstacles.Add(obstacle);
            }
        }
    }

    public override bool Stage(StarShip? ship, int astronomicUnits)
    {
        if (ship == null) return false;

        if (ship.ClassOfEngine is not TypeEngineC or TypeEngineE) return false;

        if (ship.ClassOfDeflectors != null && ship.ClassOfDeflectors.DefenceTurnOff())
        {
            if (ship.ClassOfHull != null && ship.ClassOfHull.Defence())
            {
                ship.Destroy();
                if (ship.Destroyed) return false;

                ship.ClassOfHull?.Damage(_obstacles.Count, _obstacles);
            }
        }

        ship.ClassOfDeflectors?.Damage(_obstacles.Count, _obstacles);

        if (ship.ClassOfDeflectors != null && ship.ClassOfDeflectors.DefenceTurnOff()) return false;

        if (ship.ClassOfSize != null) ship.ClassOfEngine?.Duration(astronomicUnits, ship.ClassOfSize);

        return true;
    }
}