namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines.TypeJump;

public class TypeJumpEngineAlpha : TypeEngineJump
{
    public TypeJumpEngineAlpha(int fuel)
    {
        CapacityGravityFuel = fuel;
    }

    public override int Duration(int astronomicUnits)
    {
        if (astronomicUnits >= 100) throw new CustomExceptions("Too far to move");

        for (int i = 1; i <= astronomicUnits; i++)
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