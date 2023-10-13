namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines.TypeJump;

public class TypeJumpEngineOmega : TypeEngineJump
{
    private const int LimitForOmega = 300;
    public TypeJumpEngineOmega(int fuel)
    {
        CapacityGravityFuel = fuel;
    }

    public override void Duration(int astronomicUnits)
    {
        if (astronomicUnits > LimitForOmega)
        {
            TooFar = true;
            return;
        }

        for (int i = 1; i <= astronomicUnits; i *= 2)
        {
            CapacityGravityFuel -= i;
        }
    }
}