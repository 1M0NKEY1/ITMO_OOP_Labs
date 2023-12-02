using Itmo.ObjectOrientedProgramming.Lab1.Ship.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines.TypeJump;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Size;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Models;

public abstract class StarShip
{
    public bool Crew { get; protected set; }
    public bool Photon { get; set; }
    public Deflector? ClassOfDeflectors { get; protected init; }
    public Hull? ClassOfHull { get; protected init; }
    public Engine? ClassOfEngine { get; protected init; }
    public TypeEngineJump? ClassOfJumpEngine { get; protected init; }
    public ShipSize? ClassOfSize { get; protected init; }
    public bool Destroyed { get; protected set; }
    public abstract void Destroy();
}