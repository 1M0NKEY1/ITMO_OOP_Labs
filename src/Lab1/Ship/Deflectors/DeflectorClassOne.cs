using Itmo.ObjectOrientedProgramming.Lab1.Environments;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Deflectors;

public class DeflectorClassOne : Deflector
{
    public DeflectorClassOne(bool photon)
    {
        DestroyedDeflector = false;
        DeflectorDefencePoint = 2;
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
                DeflectorDefencePoint -= 2 * countOfObstacles;
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
        }
    }
}