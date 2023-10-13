namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines.TypeJump;

public abstract class TypeEngineJump
{
    public bool TooFar { get; protected set; }
    public int CapacityGravityFuel { get; protected set; }
    public abstract void Duration(int astronomicUnits);
}