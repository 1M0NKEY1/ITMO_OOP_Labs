using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments;

namespace Itmo.ObjectOrientedProgramming.Lab1;

public class HullClassTwo : Hull
{
    private const int DefencePoint = 5;
    private const int ClassTwoRate = 3;
    private const int EndDefence = 0;
    public HullClassTwo()
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
            HullDefencePoint -= countOfObstacles * ClassTwoRate;
        }
        else if (obstacle is SpaceWhales)
        {
            HullDestroyed = true;
            HullDefencePoint = EndDefence;
        }
    }
}