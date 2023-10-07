using Itmo.ObjectOrientedProgramming.Lab1.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Fuel;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines.TypeJump;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

namespace Itmo.ObjectOrientedProgramming.Lab1.Routes;

public class Route
{
    private readonly bool _photon;
    private readonly MiningBuild _extractedPlasmFuel = new MiningBuild();
    private readonly MiningBuild _extractedGravityFuel = new MiningBuild();

    private readonly FuelExchange _fuelExchange = new FuelExchange();

    private StarShip? _currentShip;
    private Environment? _currentEnvironment;
    private Deflector? _currentDeflector;
    private Hull? _currentHull;
    private Engine? _currentEngine;
    private TypeEngineJump? _currentJumpEngine;

    public Route(bool photon, int plasmFuel, int gravityFuel)
    {
        _photon = photon;
        _extractedPlasmFuel.ExtractedPlasmFuel = plasmFuel;
        _extractedGravityFuel.ExtractedGravityFuel = gravityFuel;
    }

    public int CostOfStep(int environment, int astronomicUnits)
    {
        return environment switch
        {
            (int)SelectEnvironment.SimpleSpace => _fuelExchange.ExchangeCostOfPlasmFuel(astronomicUnits),
            (int)SelectEnvironment.NeutrinoFog => _fuelExchange.ExchangeCostOfPlasmFuel(astronomicUnits),
            (int)SelectEnvironment.SuperFog => _fuelExchange.ExchangeCostOfGravityFuel(astronomicUnits),
            _ => throw new CustomExceptions("No such type of environment"),
        };
    }

    public bool Step(int ship, int environment, int obstacles1, int obstacles2, int astronomicUnits)
    {
        _currentShip = GetShip(ship);
        _currentEnvironment = GetEnvironment(environment, obstacles1, obstacles2);
        _currentDeflector = GetDeflector(_currentShip.ClassOfDeflectors);
        _currentHull = GetHull(_currentShip.ClassOfHull);
        _currentEngine = GetEngine(_currentShip.ClassOfEngine);
        _currentJumpEngine = GetJumpEngine(_currentShip.ClassOfJumpEngine);

        if (_currentEnvironment.ExtraConditions(_currentShip.ClassOfJumpEngine))
        {
            if (_currentShip.PhotonDeflector)
            {
                _currentJumpEngine.Duration(astronomicUnits);
                if (_currentJumpEngine.TooFar)
                {
                    return false;
                }

                _currentDeflector.Damage(obstacles1, (int)Obstacles.Flashes);
                if (_currentDeflector.PhotonDeflectorDefencePoint < 0)
                {
                    _currentShip.Crew = false;
                    return false;
                }

                return true;
            }

            return false;
        }

        if (_currentEnvironment.Conditions(_currentShip.ClassOfEngine) ||
            _currentEnvironment.ExtraConditions(_currentShip.ClassOfEngine))
        {
            if (_currentDeflector.DefenceTurnOff())
            {
                if (_currentHull.Defence())
                {
                    _currentShip.Destroy();
                    if (!_currentShip.Destroyed)
                    {
                        return false;
                    }
                }

                _currentHull.Damage(obstacles1, _currentEnvironment.ClassOfObstacle1);
                _currentHull.Damage(obstacles2, _currentEnvironment.ClassOfObstacle2);
            }

            _currentDeflector.Damage(obstacles1, _currentEnvironment.ClassOfObstacle1);
            _currentDeflector.Damage(obstacles2, _currentEnvironment.ClassOfObstacle2);

            _currentEngine.Duration(astronomicUnits, _currentShip.Size);
            return true;
        }

        return false;
    }

    private static Environment GetEnvironment(int environment, int obstacles1, int obstacles2)
    {
        return environment switch
        {
            (int)SelectEnvironment.SimpleSpace => new SimpleSpace(obstacles1, obstacles2),
            (int)SelectEnvironment.NeutrinoFog => new NeutrinoFog(obstacles1),
            (int)SelectEnvironment.SuperFog => new SuperFog(obstacles1),
            _ => throw new CustomExceptions("No such type of environment"),
        };
    }

    private static Hull GetHull(int hull)
    {
        return hull switch
        {
            (int)SelectHull.HullClassOne => new HullClassOne(),
            (int)SelectHull.HullClassTwo => new HullClassTwo(),
            (int)SelectHull.HullClassThree => new HullClassThree(),
            _ => throw new CustomExceptions("No such type of hull"),
        };
    }

    private Deflector GetDeflector(int deflector)
    {
        return deflector switch
        {
            (int)SelectDeflectors.DeflectorsClassOne => new DeflectorClassOne(_photon),
            (int)SelectDeflectors.DeflectorsClassTwo => new DeflectorClassTwo(_photon),
            (int)SelectDeflectors.DeflectorsClassThree => new DeflectorClassThree(_photon),
            _ => throw new CustomExceptions("No such type of deflector"),
        };
    }

    private Engine GetEngine(int engine)
    {
        return engine switch
        {
            (int)SelectEngine.TypeEngineC => new TypeEngineC(_extractedPlasmFuel.ExtractedPlasmFuel),
            (int)SelectEngine.TypeEngineE => new TypeEngineE(_extractedPlasmFuel.ExtractedPlasmFuel),
            _ => throw new CustomExceptions("No such type of engine"),
        };
    }

    private TypeEngineJump GetJumpEngine(int jumpEngine)
    {
        return jumpEngine switch
        {
            (int)SelectJumpEngine.Alpha => new TypeJumpEngineAlpha(_extractedGravityFuel.ExtractedGravityFuel),
            (int)SelectJumpEngine.Omega => new TypeJumpEngineOmega(_extractedGravityFuel.ExtractedGravityFuel),
            (int)SelectJumpEngine.Gamma => new TypeJumpEngineGamma(_extractedGravityFuel.ExtractedGravityFuel),
            _ => throw new CustomExceptions("No such type of jump engine"),
        };
    }

    private StarShip GetShip(int ship)
    {
        return ship switch
        {
            (int)SelectShip.Avgur => new Avgur(_photon),
            (int)SelectShip.Meridian => new Meridian(_photon),
            (int)SelectShip.Stella => new Stella(_photon),
            (int)SelectShip.Vaclas => new Vaclas(_photon),
            (int)SelectShip.WalkingShuttle => new WalkingShuttle(_photon),
            _ => throw new CustomExceptions("No such type of ship"),
        };
    }
}