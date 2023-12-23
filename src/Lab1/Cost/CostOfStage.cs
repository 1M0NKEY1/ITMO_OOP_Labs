using Itmo.ObjectOrientedProgramming.Lab1.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Fuel;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Routes;

public class CostOfStage
{
    private static int _gravityFuel;
    private static int _plasmFuel;
    private readonly FuelExchange _fuelExchange = new();

    public CostOfStage(int plasmFuel, int gravityFuel)
    {
        _gravityFuel = gravityFuel;
        _plasmFuel = plasmFuel;
    }

    public int Cost(StarShip? ship, Environment environment, int astronomicUnits)
    {
        if (ship == null) throw new CustomExceptions("something happened");
        if (ship.ClassOfSize == null) throw new CustomExceptions("no such size");
        if (ship.ClassOfEngine == null) throw new CustomExceptions("no such engine");

        switch (environment)
        {
            case SimpleSpace or SimpleSpace:
                return (_plasmFuel - ship.ClassOfEngine.Duration(astronomicUnits, ship.ClassOfSize)) *
                       _fuelExchange.ExchangeCostOfPlasmFuel(astronomicUnits);

            case SuperFog when ship.ClassOfJumpEngine != null:
                ship.ClassOfJumpEngine.Duration(astronomicUnits);
                return (_gravityFuel - ship.ClassOfJumpEngine.CapacityGravityFuel) *
                       _fuelExchange.ExchangeCostOfGravityFuel(astronomicUnits);

            default:
                throw new CustomExceptions("something happened");
        }
    }
}