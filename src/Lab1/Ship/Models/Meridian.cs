using Itmo.ObjectOrientedProgramming.Lab1.Ship.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Size;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Models;

public class Meridian : StarShip
{
    private static int _fuel;
    private readonly Deflector _deflectorClassTwo = new DeflectorClassTwo(true);
    private readonly Hull _hullClassTwo = new HullClassTwo();
    private readonly Engine _engineE = new TypeEngineE(_fuel);
    private readonly ShipSize _middle = new Middle();

    public Meridian(int plasmFuel)
    {
        Crew = true;
        Destroyed = false;
        _deflectorClassTwo.Photon = Photon;
        _fuel = plasmFuel;

        ClassOfDeflectors = _deflectorClassTwo;
        ClassOfHull = _hullClassTwo;
        ClassOfEngine = _engineE;
        ClassOfSize = _middle;
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