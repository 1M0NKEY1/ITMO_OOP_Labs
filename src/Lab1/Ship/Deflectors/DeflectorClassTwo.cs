namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Deflectors;

public class DeflectorClassTwo : Deflector
{
    public DeflectorClassTwo()
    {
        DestroyedDeflector = false;
        DeflectorDefencePoint = 10;
    }

    public override int Damage(int countOfObstacles, int classOfObstacles)
    {
        switch (classOfObstacles)
        {
            case 1:
                DeflectorDefencePoint -= countOfObstacles;
                break;
            case 2:
                if (countOfObstacles >= 3)
                {
                    DeflectorDefencePoint = 0;
                    DestroyedDeflector = true;
                    break;
                }

                DeflectorDefencePoint -= (int)(3.33 * countOfObstacles);
                break;
            case 3:
                if (Emitter)
                {
                    break;
                }

                DestroyedDeflector = true;
                DeflectorDefencePoint = 0;
                break;
            default:
                throw new CustomExceptions("No such class of deflectors");
        }

        return DeflectorDefencePoint;
    }
}