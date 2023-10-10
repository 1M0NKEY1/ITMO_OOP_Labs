using Itmo.ObjectOrientedProgramming.Lab1.Ship.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Models;

public class Avgur : StarShip
{
    private readonly DeflectorClassThree _deflectorClassThree = new(false);
    private readonly DeflThree _deflThree = new();

    private readonly HullClassThree _hullClassThree = new();
    private readonly HullThree _hullThree = new();

    private readonly EngineE _engineE = new();
    private readonly Alpha _alpha = new();

    private readonly Big _big = new();

    public Avgur(bool photonDeflector)
    {
        Crew = true;
        _deflectorClassThree.Emitter = false;
        _deflectorClassThree.PhotonDeflector = photonDeflector;

        ClassOfDeflectors = _deflThree.GetNumOfDeflector();
        ClassOfEngine = _engineE.GetNumOfEngine();
        ClassOfHull = _hullThree.GetNumOfHull();
        Size = _big.GetNumOfSize();
        ClassOfJumpEngine = _alpha.GetNumOfJumpEngine();

        Destroyed = false;
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