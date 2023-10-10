using Itmo.ObjectOrientedProgramming.Lab1.Ship.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Models;

public class Meridian : StarShip
{
    private readonly DeflectorClassTwo _deflectorClassTwo = new(false);
    private readonly DeflTwo _deflTwo = new();

    private readonly HullClassTwo _hullClassTwo = new();
    private readonly HullTwo _hullTwo = new();

    private readonly EngineE _engineE = new();

    private readonly Middle _middle = new();

    public Meridian(bool photonDeflector)
    {
        Crew = true;
        _deflectorClassTwo.Emitter = true;
        _deflectorClassTwo.PhotonDeflector = photonDeflector;

        ClassOfDeflectors = _deflTwo.GetNumOfDeflector();
        ClassOfEngine = _engineE.GetNumOfEngine();
        ClassOfHull = _hullTwo.GetNumOfHull();
        Size = _middle.GetNumOfSize();
        ClassOfJumpEngine = 0;

        Destroyed = false;
    }

    public override void Destroy()
    {
        if (!_deflectorClassTwo.DefenceTurnOff()) return;
        if (!_hullClassTwo.Defence()) return;
        if (_deflectorClassTwo.PhotonDeflectorDefencePoint < 0)
        {
            Crew = false;
            Destroyed = false;
        }

        Crew = false;
        Destroyed = true;
        throw new CustomExceptions("Meridian destroyed");
    }
}