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
    private readonly bool _emitter;
    private readonly bool _photon;
    private readonly MiningBuild _extractedPlasmFuel = new MiningBuild();
    private readonly MiningBuild _extractedGravityFuel = new MiningBuild();

    private FuelExchange _fuelExchange = new FuelExchange();
    private int _countOfSteps;

    public Route(int countOfSteps, int plasmFuel, int gravityFuel)
    {
        _countOfSteps = countOfSteps;
        _extractedPlasmFuel.ExtractedPlasmFuel = plasmFuel;
        _extractedGravityFuel.ExtractedGravityFuel = gravityFuel;
    }

    public Route(bool emitter, bool photon)
    {
        _emitter = emitter;
        _photon = photon;
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

    public void Step(int ship, int environment, int obstacles1, int obstacles2, int astronomicUnits)
    {
        StarShip starship = GetShip(ship);
        Environment env = GetEnvironment(environment, obstacles1, obstacles2, astronomicUnits);
        Deflector defl = GetDeflector(starship.ClassOfDeflectors);
        Hull hull = GetHull(starship.ClassOfHull);
        Engine engine = GetEngine(starship.ClassOfEngine);
        TypeEngineJump jumpEngine = GetJumpEngine(starship.ClassOfJumpEngine);

        if (env.Conditions(starship.ClassOfEngine))
        {
            if (defl.DefenceTurnOff())
            {
                if (hull.Defence())
                {
                    starship.Destroy();
                }

                hull.Damage(obstacles1, env.ClassOfObstacle1);
                hull.Damage(obstacles2, env.ClassOfObstacle2);
            }

            defl.Damage(obstacles1, env.ClassOfObstacle1);
            defl.Damage(obstacles2, env.ClassOfObstacle2);

            if (environment is (int)SelectEnvironment.SuperFog)
            {
                jumpEngine.Duration(astronomicUnits);
            }

            engine.Duration(astronomicUnits, starship.Size);
        }
    }

    private static Environment GetEnvironment(int environment, int obstacles1, int obstacles2, int astronomicUnits)
    {
        return environment switch
        {
            (int)SelectEnvironment.SimpleSpace => new SimpleSpace(astronomicUnits, obstacles1, obstacles2),
            (int)SelectEnvironment.NeutrinoFog => new NeutrinoFog(astronomicUnits, obstacles1),
            (int)SelectEnvironment.SuperFog => new SuperFog(astronomicUnits, obstacles1),
            _ => throw new CustomExceptions("No such type of environment"),
        };
    }

    private static Deflector GetDeflector(int deflector)
    {
        return deflector switch
        {
            (int)SelectDeflectors.DeflectorsClassOne => new DeflectorClassOne(),
            (int)SelectDeflectors.DeflectorsClassTwo => new DeflectorClassTwo(),
            (int)SelectDeflectors.DeflectorsClassThree => new DeflectorClassThree(),
            _ => throw new CustomExceptions("No such type of deflector"),
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
            (int)SelectShip.Avgur => new Avgur(_emitter, _photon),
            (int)SelectShip.Meridian => new Meridian(_emitter, _photon),
            (int)SelectShip.Stella => new Stella(_emitter, _photon),
            (int)SelectShip.Vaclas => new Vaclas(_emitter, _photon),
            (int)SelectShip.WalkingShuttle => new WalkingShuttle(_emitter, _photon),
            _ => throw new CustomExceptions("No such type of ship"),
        };
    }
}