using Itmo.ObjectOrientedProgramming.Lab1.Environments;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Deflectors;

public class DeflectorClassThree : Deflector
{
    public DeflectorClassThree(bool photon)
    {
        DestroyedDeflector = false;
        DeflectorDefencePoint = 40;
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
        }
    }
}