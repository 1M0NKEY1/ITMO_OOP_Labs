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

    public override void Damage(int countOfObstacles, IList<Obstacles> obstacle, int iStep)
    {
        if (obstacle[iStep] is Asteroids)
        {
            HullDefencePoint -= countOfObstacles;
        }
        else if (obstacle[iStep] is Meteorites)
        {
            HullDefencePoint -= countOfObstacles * ClassTwoRate;
        }
        else if (obstacle[iStep] is SpaceWhales)
        {
            HullDestroyed = true;
            HullDefencePoint = EndDefence;
        }
    }
}