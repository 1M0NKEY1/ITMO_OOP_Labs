using Itmo.ObjectOrientedProgramming.Lab1.Environments;

namespace Itmo.ObjectOrientedProgramming.Lab1;

public class HullClassTwo : Hull
{
    public HullClassTwo()
    {
        HullDestroyed = false;
        HullDefencePoint = 5;
    }

    public override void Damage(int countOfObstacles, int classOfObstacles)
    {
        switch (classOfObstacles)
        {
            case (int)Obstacles.Asteroids:
                HullDefencePoint -= countOfObstacles;
                break;
            case (int)Obstacles.Meteorites:
                HullDefencePoint -= (int)(countOfObstacles * 2.5);
                break;
            case (int)Obstacles.SpaceWhales:
                HullDestroyed = true;
                HullDefencePoint = 0;
                break;
            case (int)Obstacles.Flashes:
                break;
        }
    }
}