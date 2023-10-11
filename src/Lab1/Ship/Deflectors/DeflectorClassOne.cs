using Itmo.ObjectOrientedProgramming.Lab1.Environments;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Deflectors;

public class DeflectorClassOne : Deflector
{
    private readonly Asteroids? _asteroids = new();
    private readonly Meteorites? _meteorites = new();
    private readonly SpaceWhales? _spaceWhales = new();
    private readonly Flashes? _flashes = new();
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
        if (_asteroids != null && classOfObstacles == _asteroids.GetNumOfObstacle())
        {
            DeflectorDefencePoint -= countOfObstacles;
        }
        else if (_meteorites != null && classOfObstacles == _meteorites.GetNumOfObstacle())
        {
            DeflectorDefencePoint -= 2 * countOfObstacles;
        }
        else if (_spaceWhales != null && classOfObstacles == _spaceWhales.GetNumOfObstacle())
        {
            DestroyedDeflector = true;
            DeflectorDefencePoint = -1;
        }
        else if (_flashes != null && _flashes.GetNumOfObstacle() == classOfObstacles)
        {
            PhotonDeflectorDefencePoint -= countOfObstacles;
        }
    }
}