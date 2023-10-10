using Itmo.ObjectOrientedProgramming.Lab1.Environments;

namespace Itmo.ObjectOrientedProgramming.Lab1;

public class HullClassThree : Hull
{
    public HullClassThree()
    {
        HullDestroyed = false;
        HullDefencePoint = 20;
    }

    public override void Damage(int countOfObstacles, int classOfObstacles)
    {
        switch (classOfObstacles)
        {
            case (int)Obstacles.Asteroids:
                HullDefencePoint -= countOfObstacles;
                break;
            case (int)Obstacles.Meteorites:
                HullDefencePoint -= countOfObstacles * 4;
                break;
            case (int)Obstacles.SpaceWhales:
                HullDefencePoint = 0;
                break;
            case (int)Obstacles.Flashes:
                break;
        }
    }
}