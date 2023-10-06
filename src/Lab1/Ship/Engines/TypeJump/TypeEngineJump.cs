namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines.TypeJump;

public abstract class TypeEngineJump
{
    public int CapacityGravityFuel { get; set; }
    public abstract int Duration(int astronomicUnits);
}