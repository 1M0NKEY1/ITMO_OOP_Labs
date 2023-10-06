namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines;

public abstract class Engine
{
    public int CapacityPlasmFuel { get; set; }

    public abstract int Duration(int astronomicUnits, int size);
    protected int StartEngine()
    {
        return CapacityPlasmFuel - (CapacityPlasmFuel / 100);
    }
}