using Itmo.ObjectOrientedProgramming.Lab1.Environments;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Deflectors;

public class DeflectorClassThree : Deflector
{
    private readonly Asteroids? _asteroids = new();
    private readonly Meteorites? _meteorites = new();
    private readonly SpaceWhales? _spaceWhales = new();
    private readonly Flashes? _flashes = new();
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
        if (_asteroids != null && _asteroids.GetNumOfObstacle() == classOfObstacles)
        {
            DeflectorDefencePoint -= countOfObstacles;
        }
        else if (_meteorites != null && _meteorites.GetNumOfObstacle() == classOfObstacles)
        {
            DeflectorDefencePoint -= 4 * countOfObstacles;
        }
        else if (_spaceWhales != null && _spaceWhales.GetNumOfObstacle() == classOfObstacles)
        {
            if (Emitter)
            {
                return;
            }

            DeflectorDefencePoint -= countOfObstacles;
        }
        else if (_flashes != null && _flashes.GetNumOfObstacle() == classOfObstacles)
        {
            PhotonDeflectorDefencePoint -= countOfObstacles;
        }
    }
}