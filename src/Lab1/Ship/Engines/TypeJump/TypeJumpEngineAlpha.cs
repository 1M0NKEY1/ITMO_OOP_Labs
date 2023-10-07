namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines.TypeJump;

public class TypeJumpEngineAlpha : TypeEngineJump
{
    public TypeJumpEngineAlpha(int fuel)
    {
        TooFar = false;
        CapacityGravityFuel = fuel;
    }

    public override void Duration(int astronomicUnits)
    {
        if (astronomicUnits >= 100)
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