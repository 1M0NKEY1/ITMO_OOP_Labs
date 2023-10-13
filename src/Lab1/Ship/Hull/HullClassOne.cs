using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments;

namespace Itmo.ObjectOrientedProgramming.Lab1;

public class HullClassOne : Hull
{
    private const int DefencePoint = 1;
    private const int EndDefence = 0;
    public HullClassOne()
    {
        HullDestroyed = false;
        HullDefencePoint = DefencePoint;
    }

    public override void Damage(int countOfObstacles, IList<object> obstacle)
    {
        if (obstacle is Asteroids)
        {
            HullDefencePoint -= countOfObstacles;
        }
        else if (obstacle is Meteorites)
        {
            HullDestroyed = true;
            HullDefencePoint = EndDefence;
        }
        else if (obstacle is SpaceWhales)
        {
            HullDestroyed = true;
            HullDefencePoint = EndDefence;
        }
    }
}