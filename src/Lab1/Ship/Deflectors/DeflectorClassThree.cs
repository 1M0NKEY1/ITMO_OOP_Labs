using Itmo.ObjectOrientedProgramming.Lab1.Environments;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Deflectors;

public class DeflectorClassThree : Deflector
{
    public DeflectorClassThree()
    {
        DestroyedDeflector = false;
        DeflectorDefencePoint = 40;
    }

    public override int Damage(int countOfObstacles, int classOfObstacles)
    {
        switch (classOfObstacles)
        {
            case (int)Obstacles.Asteroids:
                DeflectorDefencePoint -= countOfObstacles;
                break;
            case 2:
                DeflectorDefencePoint -= 4 * countOfObstacles;
                break;
            case 3:
                if (Emitter)
                {
                    break;
                }

                DeflectorDefencePoint -= countOfObstacles;
                break;
            default:
                throw new CustomExceptions("No such class of deflectors");
        }

        return DeflectorDefencePoint;
    }
}