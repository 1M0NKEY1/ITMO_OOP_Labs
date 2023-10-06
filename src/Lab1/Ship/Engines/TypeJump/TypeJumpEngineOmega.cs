namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines.TypeJump;

public class TypeJumpEngineOmega : TypeEngineJump
{
    public TypeJumpEngineOmega(int fuel)
    {
        CapacityGravityFuel = fuel;
    }

    public override int Duration(int astronomicUnits)
    {
        if (astronomicUnits >= 500) throw new CustomExceptions("Too far to move");

        for (int i = 1; i <= astronomicUnits; i *= 2)
        {
            if (CapacityGravityFuel <= 0)
            {
                throw new CustomExceptions("Gravity fuel tank is empty");
            }

            CapacityGravityFuel -= i;
        }

        return CapacityGravityFuel;
    }
}