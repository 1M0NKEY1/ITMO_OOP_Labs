using Itmo.ObjectOrientedProgramming.Lab1.Ship.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Models;

public class Vaclas : StarShip
{
    private readonly DeflectorClassOne _deflectorClassOne = new(false);
    private readonly DeflOne _deflOne = new();

    private readonly HullClassOne _hullClassOne = new();
    private readonly HullTwo _hullTwo = new();

    private readonly EngineE _engineE = new();
    private readonly Gamma _gamma = new();

    private readonly Middle _middle = new();

    public Vaclas(bool photonDeflector)
    {
        Crew = true;
        _deflectorClassOne.Emitter = false;
        _deflectorClassOne.PhotonDeflector = photonDeflector;

        ClassOfDeflectors = _deflOne.GetNumOfDeflector();
        ClassOfEngine = _engineE.GetNumOfEngine();
        ClassOfHull = _hullTwo.GetNumOfHull();
        Size = _middle.GetNumOfSize();
        ClassOfJumpEngine = _gamma.GetNumOfJumpEngine();

        Destroyed = false;
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
        throw new CustomExceptions("Vaclas destroyed");
    }
}