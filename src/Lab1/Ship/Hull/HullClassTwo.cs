namespace Itmo.ObjectOrientedProgramming.Lab1;

public class HullClassTwo : Hull
{
    public HullClassTwo()
    {
        HullDestroyed = false;
        HullDefencePoint = 5;
    }

    public override int Damage(int countOfObstacles, int classOfObstacles)
    {
        switch (classOfObstacles)
        {
            case 1:
                HullDefencePoint -= countOfObstacles;
                break;
            case 2:
                HullDefencePoint -= (int)(countOfObstacles * 2.5);
                break;
            case 3:
                HullDestroyed = true;
                HullDefencePoint = 0;
                break;
            default:
                throw new CustomExceptions("No such class of obstacle");
        }

        return HullDefencePoint;
    }
}