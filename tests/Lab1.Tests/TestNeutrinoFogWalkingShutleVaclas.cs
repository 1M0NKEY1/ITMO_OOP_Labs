using System.Collections;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class TestNeutrinoFogWalkingShutleVaclas
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

    public static bool IsFinishedStep(StarShip? ship)
    {
        var neutrinoFog = new NeutrinoFog(_obstacles);

        return neutrinoFog.Stage(ship, AstronomicUnits);
    }

    public IEnumerator GetEnumerator()
    {
        return GetEnumerator();
    }

    [Theory]
    [MemberData(nameof(GetObjects), MemberType = typeof(TestNeutrinoFogWalkingShutleVaclas))]
    public void AllObjectsAreOddWithMemberDataFromDataGenerator(WalkingShuttle walkingShuttle, Vaclas vaclas)
    {
        Assert.False(IsFinishedStep(walkingShuttle));
        Assert.True(IsFinishedStep(vaclas));
    }
}