using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1;

public abstract class Environment
{
    public abstract bool Stage(StarShip? ship, int astronomicUnits);
}