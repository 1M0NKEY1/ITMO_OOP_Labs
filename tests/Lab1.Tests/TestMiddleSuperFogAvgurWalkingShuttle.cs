using System.Collections;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class TestMiddleSuperFogAvgurWalkingShuttle
{
    private const int PlasmFuel = 1000000;
    private const int GravityFuel = 1000000;
    private const int AstronomicUnits = 300;
    private const bool PhotonOn = true;

    private static readonly IList<Obstacles> _obstacles = new List<Obstacles>();
    public static IEnumerable<object[]> GetObjects
    {
        get
        {
            yield return new object[] { new WalkingShuttle(PlasmFuel), new Avgur(PlasmFuel, GravityFuel) };
        }
    }

    public static bool IsFinishedStep(StarShip? ship)
    {
        var superFog = new SuperFog(_obstacles);
        if (ship != null)
        {
            ship.Photon = PhotonOn;
        }

        return superFog.Stage(ship, AstronomicUnits);
    }

    public IEnumerator GetEnumerator()
    {
        return GetEnumerator();
    }

    [Theory]
    [MemberData(nameof(GetObjects), MemberType = typeof(TestMiddleSuperFogAvgurWalkingShuttle))]
    public void AllObjectsAreOddWithMemberDataFromDataGenerator(WalkingShuttle walkingShuttle, Avgur avgur)
    {
        Assert.False(IsFinishedStep(walkingShuttle));
        Assert.False(IsFinishedStep(avgur));
    }
}