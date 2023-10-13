using Itmo.ObjectOrientedProgramming.Lab1.Ship.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines.TypeJump;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Size;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Models;

public class Stella : StarShip
{
    private static int _fuel;
    private static int _gravityFuel;
    private readonly Deflector _deflectorClassOne = new DeflectorClassOne();
    private readonly Hull _hullClassOne = new HullClassOne();
    private readonly Engine _engineC = new TypeEngineC(_fuel);
    private readonly TypeEngineJump _omega = new TypeJumpEngineOmega(_gravityFuel);
    private readonly ShipSize _small = new Small();

    public Stella(int plasmFuel, int gravityFuel)
    {
        Crew = true;
        Destroyed = false;
        _deflectorClassOne.Photon = Photon;
        _fuel = plasmFuel;
        _gravityFuel = gravityFuel;

        ClassOfDeflectors = _deflectorClassOne;
        ClassOfHull = _hullClassOne;
        ClassOfEngine = _engineC;
        ClassOfJumpEngine = _omega;
        ClassOfSize = _small;
    }

    public override void Destroy()
    {
        if (!_deflectorClassOne.DestroyedDeflector) return;
        if (!_hullClassOne.HullDestroyed) return;
        if (_deflectorClassOne.PhotonDeflectorDefencePoint < 0)
        {
            Crew = false;
            Destroyed = false;
        }

        Crew = false;
        Destroyed = true;
        throw new CustomExceptions("Stella destroyed");
    }
}