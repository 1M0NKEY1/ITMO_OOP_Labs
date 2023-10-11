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
    private static int _gravityFuel;
    private static int _plasmFuel;

    private readonly bool _photon;

    private readonly FuelExchange _fuelExchange = new();

    private readonly NumOfNeutrinoFog _numOfNeutrinoFog = new();
    private readonly NumOfSuperFog _numOfSuperFog = new();
    private readonly NumOfSimpleSpace _numOfSimpleSpace = new();

    private readonly Flashes _flashes = new();

    private readonly ShipAvgur _shipAvgur = new();
    private readonly ShipStella _shipStella = new();
    private readonly ShipMeridian _shipMeridian = new();
    private readonly ShipVaclas _shipVaclas = new();
    private readonly ShipWalkingShuttle _shipWalkingShuttle = new();

    private readonly DeflOne _deflOne = new();
    private readonly DeflTwo _deflTwo = new();
    private readonly DeflThree _deflThree = new();

    private readonly HullOne _hullOne = new();
    private readonly HullTwo _hullTwo = new();
    private readonly HullThree _hullThree = new();

    private readonly EngineC _engineC = new();
    private readonly EngineE _engineE = new();

    private readonly Alpha _alpha = new();
    private readonly Omega _omega = new();
    private readonly Gamma _gamma = new();

    private StarShip? _currentShip;
    private Environment? _currentEnvironment;
    private Deflector? _currentDeflector;
    private Hull? _currentHull;
    private Engine? _currentEngine;
    private TypeEngineJump? _currentJumpEngine;

    public Route(bool photon, int plasmFuel, int gravityFuel)
    {
        _photon = photon;
        _gravityFuel = gravityFuel;
        _plasmFuel = plasmFuel;
    }

    public int CostOfStep(int environment, int astronomicUnits, int ship)
    {
        _currentShip = GetShip(ship);
        if (_currentShip != null)
        {
            _currentEngine = GetEngine(_currentShip.ClassOfEngine);
            _currentJumpEngine = GetJumpEngine(_currentShip.ClassOfJumpEngine);
            if (_currentEngine != null)
            {
                int size = _currentShip.Size;

                if (environment == _numOfSimpleSpace.GetNumOfEnvironment())
                {
                    return (_plasmFuel - _currentEngine.Duration(astronomicUnits, size)) * _fuelExchange.ExchangeCostOfPlasmFuel(astronomicUnits);
                }

                if (environment == _numOfNeutrinoFog.GetNumOfEnvironment())
                {
                    return (_plasmFuel - _currentEngine.Duration(astronomicUnits, size)) * _fuelExchange.ExchangeCostOfPlasmFuel(astronomicUnits);
                }

                if (environment == _numOfSuperFog.GetNumOfEnvironment())
                {
                    return _fuelExchange.ExchangeCostOfGravityFuel(astronomicUnits);
                }
            }
        }

        throw new CustomExceptions("something happened");
    }

    public bool Step(int ship, int environment, int obstaclesOne, int obstaclesTwo, int astronomicUnits)
    {
        _currentShip = GetShip(ship);
        _currentEnvironment = GetEnvironment(environment, obstaclesOne, obstaclesTwo);
        if (_currentShip != null)
        {
            _currentDeflector = GetDeflector(_currentShip.ClassOfDeflectors);
            _currentHull = GetHull(_currentShip.ClassOfHull);
            _currentEngine = GetEngine(_currentShip.ClassOfEngine);
            _currentJumpEngine = GetJumpEngine(_currentShip.ClassOfJumpEngine);

            if (environment == _numOfSuperFog.GetNumOfEnvironment())
            {
                if (_currentEnvironment != null && _currentEnvironment.ExtraConditions(_currentShip.ClassOfJumpEngine))
                {
                    if (_photon)
                    {
                        _currentJumpEngine?.Duration(astronomicUnits);
                        if (_currentJumpEngine is { TooFar: true })
                        {
                            return false;
                        }

                        _currentDeflector?.Damage(obstaclesOne, _flashes.GetNumOfObstacle());
                        if (_currentDeflector is { PhotonDeflectorDefencePoint: < 0 })
                        {
                            _currentShip.Crew = false;
                            return false;
                        }

                        return true;
                    }

                    return false;
                }
            }
            else
            {
                if (_currentEnvironment != null && _currentEnvironment.Conditions(_currentShip.ClassOfEngine))
                {
                    if (_currentDeflector != null && _currentDeflector.DefenceTurnOff())
                    {
                        if (_currentHull != null && _currentHull.Defence())
                        {
                            _currentShip.Destroy();
                            if (_currentShip.Destroyed)
                            {
                                return false;
                            }
                        }

                        _currentHull?.Damage(obstaclesOne, _currentEnvironment.ClassOfObstacleOne);
                        _currentHull?.Damage(obstaclesTwo, _currentEnvironment.ClassOfObstacleTwo);
                    }

                    _currentDeflector?.Damage(obstaclesOne, _currentEnvironment.ClassOfObstacleOne);
                    _currentDeflector?.Damage(obstaclesTwo, _currentEnvironment.ClassOfObstacleTwo);

                    if (_currentDeflector != null && _currentDeflector.DefenceTurnOff())
                    {
                        return false;
                    }

                    _currentEngine?.Duration(astronomicUnits, _currentShip.Size);
                    return true;
                }
            }
        }

        return false;
    }

    private Environment? GetEnvironment(int environment, int obstacles1, int obstacles2)
    {
        if (environment == _numOfSimpleSpace.GetNumOfEnvironment())
        {
            return new SimpleSpace(obstacles1, obstacles2);
        }

        if (environment == _numOfNeutrinoFog.GetNumOfEnvironment())
        {
            return new NeutrinoFog(obstacles1);
        }

        if (environment == _numOfSuperFog.GetNumOfEnvironment())
        {
            return new SuperFog(obstacles1);
        }

        return null;
    }

    private Hull? GetHull(int hull)
    {
        if (hull == _hullOne.GetNumOfHull())
        {
            return new HullClassOne();
        }

        if (hull == _hullTwo.GetNumOfHull())
        {
            return new HullClassTwo();
        }

        if (hull == _hullThree.GetNumOfHull())
        {
            return new HullClassThree();
        }

        return null;
    }

    private Deflector? GetDeflector(int deflector)
    {
        if (deflector == _deflOne.GetNumOfDeflector())
        {
            return new DeflectorClassOne(_photon);
        }

        if (deflector == _deflTwo.GetNumOfDeflector())
        {
            return new DeflectorClassTwo(_photon, true);
        }

        if (deflector == _deflThree.GetNumOfDeflector())
        {
            return new DeflectorClassThree(_photon);
        }

        return null;
    }

    private Engine? GetEngine(int engine)
    {
        if (engine == _engineC.GetNumOfEngine())
        {
            return new TypeEngineC(_plasmFuel);
        }

        if (engine == _engineE.GetNumOfEngine())
        {
            return new TypeEngineE(_plasmFuel);
        }

        return null;
    }

    private TypeEngineJump? GetJumpEngine(int jumpEngine)
    {
        if (jumpEngine == _alpha.GetNumOfJumpEngine())
        {
            return new TypeJumpEngineAlpha(_gravityFuel);
        }

        if (jumpEngine == _omega.GetNumOfJumpEngine())
        {
            return new TypeJumpEngineOmega(_gravityFuel);
        }

        if (jumpEngine == _gamma.GetNumOfJumpEngine())
        {
            return new TypeJumpEngineGamma(_gravityFuel);
        }

        return null;
    }

    private StarShip? GetShip(int ship)
    {
        if (ship == _shipAvgur.GetNumOfShip())
        {
            return new Avgur();
        }

        if (ship == _shipStella.GetNumOfShip())
        {
            return new Stella();
        }

        if (ship == _shipMeridian.GetNumOfShip())
        {
            return new Meridian();
        }

        if (ship == _shipVaclas.GetNumOfShip())
        {
            return new Vaclas();
        }

        if (ship == _shipWalkingShuttle.GetNumOfShip())
        {
            return new WalkingShuttle();
        }

        return null;
    }
}