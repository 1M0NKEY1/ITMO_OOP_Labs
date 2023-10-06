using Itmo.ObjectOrientedProgramming.Lab1.Ship.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Models;

public class Vaclas : StarShip
{
    private DeflectorClassOne _deflectorClassOne = new DeflectorClassOne();
    private HullClassOne _hullClassOne = new HullClassOne();

    public Vaclas(bool emitter, bool photonDeflector)
    {
        Crew = true;
        Emitter = emitter;
        PhotonDeflector = photonDeflector;
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
        Crew = false;
        Destroyed = true;
        throw new CustomExceptions("Vaclas destroyed");
    }
}