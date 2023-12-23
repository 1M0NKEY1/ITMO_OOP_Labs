namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines;

public abstract class Engine
{
    protected int CapacityPlasmFuel { get; set; }
    public abstract int Duration(int astronomicUnits, object size);
    protected int StartEngine()
    {
        return CapacityPlasmFuel - (CapacityPlasmFuel / 100);
    }
}