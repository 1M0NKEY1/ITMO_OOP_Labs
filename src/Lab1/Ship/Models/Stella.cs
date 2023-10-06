using Itmo.ObjectOrientedProgramming.Lab1.Ship.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Models;

public class Stella : StarShip
{
    private DeflectorClassOne _deflectorClassOne = new DeflectorClassOne();
    private HullClassOne _hullClassOne = new HullClassOne();

    public Stella(bool emitter, bool photonDeflector)
    {
        Crew = true;
        Emitter = emitter;
        PhotonDeflector = photonDeflector;
        ClassOfDeflectors = (int)SelectDeflectors.DeflectorsClassOne;
        ClassOfEngine = (int)SelectEngine.TypeEngineC;
        ClassOfHull = (int)SelectHull.HullClassOne;
        Size = (int)SelectSize.Small;
        ClassOfJumpEngine = (int)SelectJumpEngine.Omega;
        Destroyed = false;
    }

    public override void Destroy()
    {
        if (_deflectorClassOne.DestroyedDeflector)
        {
            if (_hullClassOne.HullDestroyed)
            {
                Crew = false;
                Destroyed = true;
                throw new CustomExceptions("Stella destroyed");
            }
        }
    }
}