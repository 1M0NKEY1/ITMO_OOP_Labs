using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

namespace Itmo.ObjectOrientedProgramming.Lab1;

public class NeutrinoFog : Environment
{
    public NeutrinoFog(int countsOfSpaceWhales)
    {
        CountsOfSpaceWhales = countsOfSpaceWhales;
    }

    public override bool Conditions(int engineType)
    {
        return engineType == (int)SelectEngine.TypeEngineE;
    }

    public override bool ExtraConditions(int engineJumpType)
    {
        return true;
    }
}