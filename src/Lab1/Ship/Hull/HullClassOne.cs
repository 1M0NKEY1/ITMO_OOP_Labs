using Itmo.ObjectOrientedProgramming.Lab1.Environments;

namespace Itmo.ObjectOrientedProgramming.Lab1;

public class HullClassOne : Hull
{
    public HullClassOne()
    {
        HullDestroyed = false;
        HullDefencePoint = 1;
    }

    public override void Damage(int countOfObstacles, int classOfObstacles)
    {
        switch (classOfObstacles)
        {
            case (int)Obstacles.Asteroids:
                HullDefencePoint -= countOfObstacles;
                break;
            case (int)Obstacles.Meteorites:
                HullDestroyed = true;
                HullDefencePoint = 0;
                break;
            case (int)Obstacles.SpaceWhales:
                HullDestroyed = true;
                HullDefencePoint = 0;
                break;
            default:
                throw new CustomExceptions("No such class of obstacle");
        }
    }
}