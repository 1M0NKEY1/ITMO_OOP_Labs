using Itmo.ObjectOrientedProgramming.Lab1.Ship.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Models;

public class Avgur : StarShip
{
    private DeflectorClassThree _deflectorClassThree = new DeflectorClassThree();
    private HullClassThree _hullClassThree = new HullClassThree();

    public Avgur(bool emitter, bool photonDeflector)
    {
        Crew = true;
        Emitter = emitter;
        PhotonDeflector = photonDeflector;
        ClassOfDeflectors = (int)SelectDeflectors.DeflectorsClassThree;
        ClassOfEngine = (int)SelectEngine.TypeEngineE;
        ClassOfHull = (int)SelectHull.HullClassThree;
        Size = (int)SelectSize.Big;
        ClassOfJumpEngine = (int)SelectJumpEngine.Alpha;
        Destroyed = false;
    }

    public override void Destroy()
    {
        if (_deflectorClassThree.DestroyedDeflector)
        {
            if (_hullClassThree.HullDestroyed)
            {
                Crew = false;
                Destroyed = true;
                throw new CustomExceptions("Avgur destroyed");
            }
        }
    }
}