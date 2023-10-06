namespace Itmo.ObjectOrientedProgramming.Lab1;

public class HullClassThree : Hull
{
    public HullClassThree()
    {
        HullDestroyed = false;
        HullDefencePoint = 20;
    }

    public override int Damage(int countOfObstacles, int classOfObstacles)
    {
        switch (classOfObstacles)
        {
            case 1:
                HullDefencePoint -= countOfObstacles;
                break;
            case 2:
                HullDefencePoint -= countOfObstacles * 4;
                break;
            case 3:
                HullDefencePoint = 0;
                break;
            default:
                throw new CustomExceptions("No such class of obstacle");
        }

        return HullDefencePoint;
    }
}