using Itmo.ObjectOrientedProgramming.Lab1.Environments;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Deflectors;

public class DeflectorClassTwo : Deflector
{
    public DeflectorClassTwo(bool photon)
    {
        DestroyedDeflector = false;
        DeflectorDefencePoint = 10;
        if (photon)
        {
            PhotonDeflectorDefencePoint = 3;
        }
    }

    public override void Damage(int countOfObstacles, int classOfObstacles)
    {
        switch (classOfObstacles)
        {
            case (int)Obstacles.Asteroids:
                DeflectorDefencePoint -= countOfObstacles;
                break;
            case (int)Obstacles.Meteorites:
                if (countOfObstacles >= 3)
                {
                    DeflectorDefencePoint = 0;
                    DestroyedDeflector = true;
                    break;
                }

                DeflectorDefencePoint -= (int)(3.33 * countOfObstacles);
                break;
            case (int)Obstacles.SpaceWhales:
                if (Emitter)
                {
                    break;
                }

                DestroyedDeflector = true;
                DeflectorDefencePoint = 0;
                break;
            case (int)Obstacles.Flashes:
                PhotonDeflectorDefencePoint -= countOfObstacles;
                break;
            default:
                throw new CustomExceptions("No such class of deflectors");
        }
    }
}