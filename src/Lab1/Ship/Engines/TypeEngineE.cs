using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines;

public class TypeEngineE : Engine
{
    private readonly Small? _small = new();
    private readonly Middle? _middle = new();
    private readonly Big? _big = new();
    public TypeEngineE(int fuel)
    {
        CapacityPlasmFuel = fuel;
    }

    public override int Duration(int astronomicUnits, int size)
    {
        CapacityPlasmFuel = StartEngine();
        for (int i = 1; i <= astronomicUnits; i *= 2)
        {
            if (_small != null && size == _small.GetNumOfSize())
            {
                CapacityPlasmFuel -= i;
            }
            else if (_middle != null && size == _middle.GetNumOfSize())
            {
                ++i;
                CapacityPlasmFuel -= i;
            }
            else if (_big != null && size == _big.GetNumOfSize())
            {
                ++i;
                ++i;
                CapacityPlasmFuel -= i;
            }
        }

        return CapacityPlasmFuel;
    }
}