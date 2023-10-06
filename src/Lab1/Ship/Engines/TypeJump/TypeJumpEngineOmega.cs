namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines.TypeJump;

public class TypeJumpEngineOmega : TypeEngineJump
{
    public TypeJumpEngineOmega(int fuel)
    {
        CapacityGravityFuel = fuel;
    }

    public override void Duration(int astronomicUnits)
    {
        if (astronomicUnits >= 500)
        {
            TooFar = true;
            return;
        }

        for (int i = 1; i <= astronomicUnits; i *= 2)
        {
            if (CapacityGravityFuel <= 0)
            {
                throw new CustomExceptions("Gravity fuel tank is empty");
            }

            CapacityGravityFuel -= i;
        }
    }
}