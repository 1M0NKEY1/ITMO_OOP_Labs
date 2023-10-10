using Itmo.ObjectOrientedProgramming.Lab1.Environments;

namespace Itmo.ObjectOrientedProgramming.Lab1;

public class HullClassOne : Hull
{
    private readonly Asteroids? _asteroids = new();
    private readonly Meteorites? _meteorites = new();
    private readonly SpaceWhales? _spaceWhales = new();
    public HullClassOne()
    {
        HullDestroyed = false;
        HullDefencePoint = 1;
    }

    public override void Damage(int countOfObstacles, int classOfObstacles)
    {
        if (_asteroids != null && classOfObstacles == _asteroids.GetNumOfObstacle())
        {
            HullDefencePoint -= countOfObstacles;
        }
        else if (_meteorites != null && classOfObstacles == _meteorites.GetNumOfObstacle())
        {
            HullDestroyed = true;
            HullDefencePoint = 0;
        }
        else if (_spaceWhales != null && classOfObstacles == _spaceWhales.GetNumOfObstacle())
        {
            HullDestroyed = true;
            HullDefencePoint = 0;
        }
    }
}