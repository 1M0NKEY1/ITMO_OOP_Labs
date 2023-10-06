namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines.TypeJump;

public class TypeJumpEngineGamma : TypeEngineJump
{
    public TypeJumpEngineGamma(int fuel)
    {
        CapacityGravityFuel = fuel;
    }

    public override int Duration(int astronomicUnits)
    {
        for (int i = 1; i <= astronomicUnits; i ^= 2)
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