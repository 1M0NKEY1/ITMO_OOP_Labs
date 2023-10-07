using Itmo.ObjectOrientedProgramming.Lab1.Ship.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Models;

public class Meridian : StarShip
{
    private DeflectorClassTwo _deflectorClassTwo = new DeflectorClassTwo(false);
    private HullClassTwo _hullClassTwo = new HullClassTwo();

    public Meridian(bool photonDeflector)
    {
        Crew = true;
        Emitter = true;
        _deflectorClassTwo.PhotonDeflector = photonDeflector;
        ClassOfDeflectors = (int)SelectDeflectors.DeflectorsClassTwo;
        ClassOfEngine = (int)SelectEngine.TypeEngineE;
        ClassOfHull = (int)SelectHull.HullClassTwo;
        Size = (int)SelectSize.Middle;
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