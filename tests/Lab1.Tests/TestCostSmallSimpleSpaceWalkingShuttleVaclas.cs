using System.Collections;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Routes;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class TestCostSmallSimpleSpaceWalkingShuttleVaclas
{
    private const int PlasmFuel = 1000000;
    private const int GravityFuel = 1000000;
    private const int AstronomicUnits = 100;

    private static readonly IList<Obstacles> _obstacles = new List<Obstacles>();
    public static IEnumerable<object[]> GetObjects
    {
        get
        {
            yield return new object[] { new WalkingShuttle(PlasmFuel), new Vaclas(PlasmFuel, GravityFuel) };
        }
    }

    public static bool CostOfFinishedStep(StarShip? shipOne, StarShip? shipTwo)
    {
        var simpleSpace = new SimpleSpace(_obstacles);
        var costOfStage = new CostOfStage(PlasmFuel, GravityFuel);
        return costOfStage.Cost(shipOne, simpleSpace, AstronomicUnits) <
               costOfStage.Cost(shipTwo, simpleSpace, AstronomicUnits);
    }

    public IEnumerator GetEnumerator()
    {
        return GetEnumerator();
    }

    [Theory]
    [MemberData(nameof(GetObjects), MemberType = typeof(TestCostSmallSimpleSpaceWalkingShuttleVaclas))]
    public void AllObjectsAreOddWithMemberDataFromDataGenerator(WalkingShuttle walkingShuttle, Vaclas vaclas)
    {
        Assert.True(CostOfFinishedStep(walkingShuttle, vaclas));
    }
}