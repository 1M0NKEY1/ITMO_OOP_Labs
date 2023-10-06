namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines.TypeJump;

public abstract class TypeEngineJump
{
    public bool TooFar { get; set; }
    protected int CapacityGravityFuel { get; set; }
    public abstract void Duration(int astronomicUnits);
}