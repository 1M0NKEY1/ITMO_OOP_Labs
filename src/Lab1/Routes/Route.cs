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
    private readonly ExtractedPlasmFuel _extractedPlasmFuel = new(_gravityFuel);
    private readonly ExtractedGravityFuel _extractedGravityFuel = new(_plasmFuel);

    private readonly FuelExchange _fuelExchange = new();

    private readonly NFog _nFog = new();
    private readonly SFog _sFog = new();
    private readonly SSpace _sSpace = new();

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

    public int CostOfStep(int environment, int astronomicUnits)
    {
        if (environment == _sSpace.GetNumOfEnvironment())
        {
            return _fuelExchange.ExchangeCostOfPlasmFuel(astronomicUnits);
        }
        else if (environment == _nFog.GetNumOfEnvironment())
        {
            return _fuelExchange.ExchangeCostOfPlasmFuel(astronomicUnits);
        }
        else if (environment == _sFog.GetNumOfEnvironment())
        {
            return _fuelExchange.ExchangeCostOfGravityFuel(astronomicUnits);
        }
        else
        {
            throw new CustomExceptions("No such type of environment");
        }
    }

    public bool Step(int ship, int environment, int obstaclesOne, int obstaclesTwo, int astronomicUnits)
    {
        _currentShip = GetShip(ship);
        _currentEnvironment = GetEnvironment(environment, obstaclesOne, obstaclesTwo);
        _currentDeflector = GetDeflector(_currentShip.ClassOfDeflectors);
        _currentHull = GetHull(_currentShip.ClassOfHull);
        _currentEngine = GetEngine(_currentShip.ClassOfEngine);
        _currentJumpEngine = GetJumpEngine(_currentShip.ClassOfJumpEngine);

        if (environment == _sFog.GetNumOfEnvironment())
        {
            if (_currentEnvironment.ExtraConditions(_currentShip.ClassOfJumpEngine))
            {
                if (_photon)
                {
                    _currentJumpEngine.Duration(astronomicUnits);
                    if (_currentJumpEngine.TooFar)
                    {
                        return false;
                    }

                    _currentDeflector.Damage(obstaclesOne, _flashes.GetNumOfObstacle());
                    if (_currentDeflector.PhotonDeflectorDefencePoint < 0)
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
            if (_currentEnvironment.Conditions(_currentShip.ClassOfEngine))
            {
                if (!_currentDeflector.DefenceTurnOff())
                {
                    if (_currentHull.Defence())
                    {
                        _currentShip.Destroy();
                        if (_currentShip.Destroyed)
                        {
                            return false;
                        }
                    }

                    _currentHull.Damage(obstaclesOne, _currentEnvironment.ClassOfObstacleOne);
                    _currentHull.Damage(obstaclesTwo, _currentEnvironment.ClassOfObstacleTwo);
                }

                _currentDeflector.Damage(obstaclesOne, _currentEnvironment.ClassOfObstacleOne);
                _currentDeflector.Damage(obstaclesTwo, _currentEnvironment.ClassOfObstacleTwo);

                if (_currentDeflector.DefenceTurnOff())
                {
                    return false;
                }

                _currentEngine.Duration(astronomicUnits, _currentShip.Size);
                return true;
            }
        }

        return false;
    }

    private Environment GetEnvironment(int environment, int obstacles1, int obstacles2)
    {
        if (environment == _sSpace.GetNumOfEnvironment())
        {
            return new SimpleSpace(obstacles1, obstacles2);
        }
        else if (environment == _nFog.GetNumOfEnvironment())
        {
            return new NeutrinoFog(obstacles1);
        }
        else if (environment == _sFog.GetNumOfEnvironment())
        {
            return new SuperFog(obstacles1);
        }
        else
        {
            throw new CustomExceptions("No such type of environment");
        }
    }

    private Hull GetHull(int hull)
    {
        if (hull == _hullOne.GetNumOfHull())
        {
            return new HullClassOne();
        }
        else if (hull == _hullTwo.GetNumOfHull())
        {
            return new HullClassTwo();
        }
        else if (hull == _hullThree.GetNumOfHull())
        {
            return new HullClassThree();
        }
        else
        {
            throw new CustomExceptions("No such type of hull");
        }
    }

    private Deflector GetDeflector(int deflector)
    {
        if (deflector == _deflOne.GetNumOfDeflector())
        {
            return new DeflectorClassOne(_photon);
        }
        else if (deflector == _deflTwo.GetNumOfDeflector())
        {
            return new DeflectorClassTwo(_photon);
        }
        else if (deflector == _deflThree.GetNumOfDeflector())
        {
            return new DeflectorClassThree(_photon);
        }
        else
        {
            throw new CustomExceptions("No such type of deflector");
        }
    }

    private Engine GetEngine(int engine)
    {
        if (engine == _engineC.GetNumOfEngine())
        {
            return new TypeEngineC(_extractedPlasmFuel.ExtractedPlasmFuel);
        }
        else if (engine == _engineE.GetNumOfEngine())
        {
            return new TypeEngineE(_extractedPlasmFuel.ExtractedPlasmFuel);
        }
        else
        {
            throw new CustomExceptions("No such type of engine");
        }
    }

    private TypeEngineJump GetJumpEngine(int jumpEngine)
    {
        if (jumpEngine == _alpha.GetNumOfJumpEngine())
        {
            return new TypeJumpEngineAlpha(_extractedGravityFuel.ExtractedGravityFuel);
        }
        else if (jumpEngine == _omega.GetNumOfJumpEngine())
        {
            return new TypeJumpEngineOmega(_extractedGravityFuel.ExtractedGravityFuel);
        }
        else if (jumpEngine == _gamma.GetNumOfJumpEngine())
        {
            return new TypeJumpEngineGamma(_extractedGravityFuel.ExtractedGravityFuel);
        }
        else
        {
            throw new CustomExceptions("No such type of jump engine");
        }
    }

    private StarShip GetShip(int ship)
    {
        if (ship == _shipAvgur.GetNumOfShip())
        {
            return new Avgur(_photon);
        }
        else if (ship == _shipStella.GetNumOfShip())
        {
            return new Stella(_photon);
        }
        else if (ship == _shipMeridian.GetNumOfShip())
        {
            return new Meridian(_photon);
        }
        else if (ship == _shipVaclas.GetNumOfShip())
        {
            return new Vaclas(_photon);
        }
        else if (ship == _shipWalkingShuttle.GetNumOfShip())
        {
            return new WalkingShuttle();
        }
        else
        {
            throw new CustomExceptions("No such type of ship");
        }
    }
}