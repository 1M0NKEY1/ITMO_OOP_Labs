using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines;

public class TypeEngineC : Engine
{
    public TypeEngineC(int fuel)
    {
        CapacityPlasmFuel = fuel;
    }

    public override int Duration(int astronomicUnits, int size)
    {
        CapacityPlasmFuel = StartEngine();
        for (int i = 1; i <= astronomicUnits; i++)
        {
            switch (size)
            {
                case (int)SelectSize.Small:
                    CapacityPlasmFuel -= i;
                    break;
                case (int)SelectSize.Middle:
                    ++i;
                    CapacityPlasmFuel -= i;
                    break;
                case (int)SelectSize.Big:
                    ++i; ++i;
                    CapacityPlasmFuel -= i;
                    break;
            }
        }

        return CapacityPlasmFuel;
    }
}