using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

namespace Itmo.ObjectOrientedProgramming.Lab1;

public class NeutrinoFog : Environment
{
    public NeutrinoFog(int astronomicUnits, int countsOfSpaceWhales)
    {
        AcceptToFly = false;
        LengthOfStep = astronomicUnits;
        CountsOfSpaceWhales = countsOfSpaceWhales;
    }

    public override bool Conditions(int engineType)
    {
        if (engineType == (int)SelectEngine.TypeEngineE)
        {
            return true;
        }

        return false;
    }
}