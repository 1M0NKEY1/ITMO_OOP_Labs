using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments;

public class SuperFog : Environment
{
    public SuperFog(int astronomicUnits, int countOfFlashes)
    {
        AcceptToFly = false;
        LengthOfStep = astronomicUnits;
        ClassOfObstacle1 = (int)Obstacles.Flashes;
        CountOfFlashes = countOfFlashes;
    }

    public override bool Conditions(int engineType)
    {
        if (engineType is (int)SelectJumpEngine.Alpha or (int)SelectJumpEngine.Gamma or (int)SelectJumpEngine.Omega)
        {
            return true;
        }

        return false;
    }
}