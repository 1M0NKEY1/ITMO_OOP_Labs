using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments;

public class SuperFog : Environment
{
    public SuperFog(int countOfFlashes)
    {
        ClassOfObstacle1 = (int)Obstacles.Flashes;
        CountOfFlashes = countOfFlashes;
    }

    public override bool Conditions(int engineType)
    {
        return false;
    }

    public override bool ExtraConditions(int engineJumpType)
    {
        return engineJumpType is (int)SelectJumpEngine.Alpha or (int)SelectJumpEngine.Gamma
            or (int)SelectJumpEngine.Omega;
    }
}