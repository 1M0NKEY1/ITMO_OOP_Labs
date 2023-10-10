using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments;

public class SimpleSpace : Environment
{
    public SimpleSpace(int countOfAsteroids, int countOfMeteorites)
    {
        ClassOfObstacleOne = (int)Obstacles.Asteroids;
        ClassOfObstacleTwo = (int)Obstacles.Meteorites;
        CountOfAsteroids = countOfAsteroids;
        CountOfMeteorites = countOfMeteorites;
    }

    public override bool Conditions(int engineType)
    {
        return engineType is (int)SelectEngine.TypeEngineC or (int)SelectEngine.TypeEngineE;
    }

    public override bool ExtraConditions(int engineJumpType)
    {
        return true;
    }
}