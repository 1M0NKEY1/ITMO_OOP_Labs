using Itmo.ObjectOrientedProgramming.Lab1.Environments;

namespace Itmo.ObjectOrientedProgramming.Lab1;

public class HullClassThree : Hull
{
    private readonly Asteroids? _asteroids = new();
    private readonly Meteorites? _meteorites = new();
    private readonly SpaceWhales? _spaceWhales = new();
    public HullClassThree()
    {
        HullDestroyed = false;
        HullDefencePoint = 20;
    }

    public override void Damage(int countOfObstacles, int classOfObstacles)
    {
        if (_asteroids != null && classOfObstacles == _asteroids.GetNumOfObstacle())
        {
            HullDefencePoint -= countOfObstacles;
        }
        else if (_meteorites != null && classOfObstacles == _meteorites.GetNumOfObstacle())
        {
            HullDefencePoint -= countOfObstacles * 4;
        }
        else if (_spaceWhales != null && classOfObstacles == _spaceWhales.GetNumOfObstacle())
        {
            HullDestroyed = true;
            HullDefencePoint = 0;
        }
    }
}