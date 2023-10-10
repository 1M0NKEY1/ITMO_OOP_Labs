using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments;

public class SimpleSpace : Environment
{
    private readonly Asteroids _asteroids = new();
    private readonly Meteorites _meteorites = new();

    private readonly EngineC _engineC = new();
    private readonly EngineE _engineE = new();

    public SimpleSpace(int countOfAsteroids, int countOfMeteorites)
    {
        ClassOfObstacleOne = _asteroids.GetNumOfObstacle();
        ClassOfObstacleTwo = _meteorites.GetNumOfObstacle();
        CountOfAsteroids = countOfAsteroids;
        CountOfMeteorites = countOfMeteorites;
    }

    public override bool Conditions(int engineType)
    {
        return engineType == _engineC.GetNumOfEngine() || engineType == _engineE.GetNumOfEngine();
    }

    public override bool ExtraConditions(int engineJumpType)
    {
        return true;
    }
}