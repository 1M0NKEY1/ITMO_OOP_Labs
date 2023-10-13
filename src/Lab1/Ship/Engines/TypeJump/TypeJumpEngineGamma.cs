namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines.TypeJump;

public class TypeJumpEngineGamma : TypeEngineJump
{
    private const int LimitForGama = 500;
    public TypeJumpEngineGamma(int fuel)
    {
        CapacityGravityFuel = fuel;
    }

    public override void Duration(int astronomicUnits)
    {
        if (astronomicUnits >= LimitForGama)
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