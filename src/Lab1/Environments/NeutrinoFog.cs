using Itmo.ObjectOrientedProgramming.Lab1.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

namespace Itmo.ObjectOrientedProgramming.Lab1;

public class NeutrinoFog : Environment
{
    private readonly SpaceWhales _spaceWhales = new();

    private readonly EngineE _engineE = new();

    public NeutrinoFog(int countOfSpaceWhales)
    {
        ClassOfObstacleOne = _spaceWhales.GetNumOfObstacle();
        CountOfSpaceWhales = countOfSpaceWhales;
    }

    public override bool Conditions(int engineType)
    {
        return engineType == _engineE.GetNumOfEngine();
    }

    public override bool ExtraConditions(int engineJumpType)
    {
        return true;
    }
}