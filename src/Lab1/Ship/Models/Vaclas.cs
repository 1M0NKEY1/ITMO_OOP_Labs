using Itmo.ObjectOrientedProgramming.Lab1.Ship.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines.TypeJump;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Size;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Models;

public class Vaclas : StarShip
{
    private static int _fuel;
    private static int _gravityFuel;
    private readonly Deflector _deflectorClassOne = new DeflectorClassOne();
    private readonly Hull _hullClassTwo = new HullClassTwo();
    private readonly Engine _engineE = new TypeEngineE(_fuel);
    private readonly TypeEngineJump _gamma = new TypeJumpEngineGamma(_gravityFuel);
    private readonly ShipSize _middle = new Middle();

    public Vaclas(int plasmFuel, int gravityFuel)
    {
        Crew = true;
        Destroyed = false;
        _deflectorClassOne.Photon = Photon;
        _fuel = plasmFuel;
        _gravityFuel = gravityFuel;

        ClassOfDeflectors = _deflectorClassOne;
        ClassOfHull = _hullClassTwo;
        ClassOfEngine = _engineE;
        ClassOfJumpEngine = _gamma;
        ClassOfSize = _middle;
    }

    public override void Destroy()
    {
        if (!_deflectorClassOne.DestroyedDeflector) return;
        if (!_hullClassTwo.HullDestroyed) return;
        if (_deflectorClassOne.PhotonDeflectorDefencePoint < 0)
        {
            Crew = false;
            Destroyed = false;
        }

        Crew = false;
        Destroyed = true;
        throw new CustomExceptions("Vaclas destroyed");
    }
}