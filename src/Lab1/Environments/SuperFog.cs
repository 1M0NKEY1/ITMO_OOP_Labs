using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments;

public class SuperFog : Environment
{
    private readonly Flashes _flashes = new();

    private readonly Alpha _alpha = new();
    private readonly Omega _omega = new();
    private readonly Gamma _gamma = new();

    public SuperFog(int countOfFlashes)
    {
        ClassOfObstacleOne = _flashes.GetNumOfObstacle();
        CountOfFlashes = countOfFlashes;
    }

    public override bool Conditions(int engineType)
    {
        return false;
    }

    public override bool ExtraConditions(int engineJumpType)
    {
        return engineJumpType == _alpha.GetNumOfJumpEngine() ||
               engineJumpType == _omega.GetNumOfJumpEngine() ||
               engineJumpType == _gamma.GetNumOfJumpEngine();
    }
}