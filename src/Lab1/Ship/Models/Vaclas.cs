using Itmo.ObjectOrientedProgramming.Lab1.Ship.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Models;

public class Vaclas : StarShip
{
    private DeflectorClassOne _deflectorClassOne = new DeflectorClassOne(false);
    private HullClassOne _hullClassOne = new HullClassOne();

    public Vaclas(bool photonDeflector)
    {
        Crew = true;
        Emitter = false;
        _deflectorClassOne.PhotonDeflector = photonDeflector;
        ClassOfDeflectors = (int)SelectDeflectors.DeflectorsClassOne;
        ClassOfEngine = (int)SelectEngine.TypeEngineE;
        ClassOfHull = (int)SelectHull.HullClassTwo;
        Size = (int)SelectSize.Middle;
        ClassOfJumpEngine = (int)SelectJumpEngine.Gamma;
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