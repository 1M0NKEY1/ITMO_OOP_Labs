using Itmo.ObjectOrientedProgramming.Lab1.Ship.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Models;

public class Stella : StarShip
{
    private readonly DeflectorClassOne _deflectorClassOne = new(false);
    private readonly DeflOne _deflOne = new();

    private readonly HullClassOne _hullClassOne = new();
    private readonly HullOne _hullOne = new();

    private readonly EngineC _engineC = new();
    private readonly Omega _omega = new();

    private readonly Small _small = new();

    public Stella()
    {
        Crew = true;

        ClassOfDeflectors = _deflOne.GetNumOfDeflector();
        ClassOfEngine = _engineC.GetNumOfEngine();
        ClassOfHull = _hullOne.GetNumOfHull();
        Size = _small.GetNumOfSize();
        ClassOfJumpEngine = _omega.GetNumOfJumpEngine();

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
        throw new CustomExceptions("Stella destroyed");
    }
}