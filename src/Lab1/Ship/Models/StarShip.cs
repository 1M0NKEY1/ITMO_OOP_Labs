namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Models;

public abstract class StarShip
{
    public bool Crew { get; set; }
    public int ClassOfDeflectors { get; protected init; }
    public int ClassOfHull { get; protected init; }
    public int ClassOfEngine { get; protected init; }
    public int ClassOfJumpEngine { get; protected init; }
    public int Size { get; protected init; }
    public bool Destroyed { get; set; }
    public abstract void Destroy();
}