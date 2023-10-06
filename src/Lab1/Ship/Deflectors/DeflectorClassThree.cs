using Itmo.ObjectOrientedProgramming.Lab1.Environments;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Deflectors;

public class DeflectorClassThree : Deflector
{
    public DeflectorClassThree()
    {
        DestroyedDeflector = false;
        DeflectorDefencePoint = 40;
    }

    public override void Damage(int countOfObstacles, int classOfObstacles)
    {
        switch (classOfObstacles)
        {
            case (int)Obstacles.Asteroids:
                DeflectorDefencePoint -= countOfObstacles;
                break;
            case (int)Obstacles.Meteorites:
                DeflectorDefencePoint -= 4 * countOfObstacles;
                break;
            case (int)Obstacles.SpaceWhales:
                if (Emitter)
                {
                    break;
                }

                DeflectorDefencePoint -= countOfObstacles;
                break;
            case (int)Obstacles.Flashes:
                PhotonDeflectorDefencePoint -= countOfObstacles;
                break;
            default:
                throw new CustomExceptions("No such class of deflectors");
        }
    }
}