using Itmo.ObjectOrientedProgramming.Lab1.Ship.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines.TypeJump;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Size;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Models;

public class Avgur : StarShip
{
    private static int _fuel;
    private static int _gravityFuel;
    private readonly Deflector _deflectorClassThree = new DeflectorClassThree();
    private readonly Hull _hullClassThree = new HullClassThree();
    private readonly Engine _engineE = new TypeEngineE(_fuel);
    private readonly TypeEngineJump _alpha = new TypeJumpEngineAlpha(_gravityFuel);
    private readonly ShipSize _big = new Big();

    public Avgur(int plasmFuel, int gravityFuel)
    {
        Crew = true;
        Destroyed = false;
        _deflectorClassThree.Photon = Photon;
        _fuel = plasmFuel;
        _gravityFuel = gravityFuel;

        ClassOfDeflectors = _deflectorClassThree;
        ClassOfHull = _hullClassThree;
        ClassOfEngine = _engineE;
        ClassOfJumpEngine = _alpha;
        ClassOfSize = _big;
    }

    public override void Destroy()
    {
        if (!_deflectorClassThree.DestroyedDeflector) return;
        if (!_hullClassThree.HullDestroyed) return;
        if (_deflectorClassThree.PhotonDeflectorDefencePoint < 0)
        {
            Crew = false;
            Destroyed = false;
        }

        Crew = false;
        Destroyed = true;
        throw new CustomExceptions("Avgur destroyed");
    }
}