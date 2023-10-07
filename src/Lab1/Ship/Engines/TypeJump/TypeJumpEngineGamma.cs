namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines.TypeJump;

public class TypeJumpEngineGamma : TypeEngineJump
{
    public TypeJumpEngineGamma(int fuel)
    {
        CapacityGravityFuel = fuel;
    }

    public override void Duration(int astronomicUnits)
    {
        if (astronomicUnits >= 300)
        {
            TooFar = true;
            return;
        }

        int i = 2;
        while (i <= astronomicUnits)
        {
            CapacityGravityFuel -= i;
            i <<= 1;
        }
    }
}