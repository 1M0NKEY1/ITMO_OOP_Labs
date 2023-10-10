using Itmo.ObjectOrientedProgramming.Lab1.Environments;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Deflectors;

public class DeflectorClassTwo : Deflector
{
    private readonly Asteroids? _asteroids = new();
    private readonly Meteorites? _meteorites = new();
    private readonly SpaceWhales? _spaceWhales = new();
    private readonly Flashes? _flashes = new();
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
        if (_asteroids != null && _asteroids.GetNumOfObstacle() == classOfObstacles)
        {
            DeflectorDefencePoint -= countOfObstacles;
        }
        else if (_meteorites != null && _meteorites.GetNumOfObstacle() == classOfObstacles)
        {
            if (countOfObstacles >= 3)
            {
                DeflectorDefencePoint = 0;
                DestroyedDeflector = true;
            }

            DeflectorDefencePoint -= (int)(3.33 * countOfObstacles);
        }
        else if (_spaceWhales != null && _spaceWhales.GetNumOfObstacle() == classOfObstacles)
        {
            if (Emitter)
            {
                return;
            }

            DestroyedDeflector = true;
            DeflectorDefencePoint = 0;
        }
        else if (_flashes != null && _flashes.GetNumOfObstacle() == classOfObstacles)
        {
            PhotonDeflectorDefencePoint -= countOfObstacles;
        }
    }
}