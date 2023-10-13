namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines.TypeJump;

public class TypeJumpEngineAlpha : TypeEngineJump
{
    private const int LimitForAlpha = 100;
    public TypeJumpEngineAlpha(int fuel)
    {
        TooFar = false;
        CapacityGravityFuel = fuel;
    }

    public override void Duration(int astronomicUnits)
    {
        if (astronomicUnits > LimitForAlpha)
        {
            TooFar = true;
            return;
        }

        for (int i = 1; i <= astronomicUnits; i++)
        {
            CapacityGravityFuel -= i;
        }
    }
}