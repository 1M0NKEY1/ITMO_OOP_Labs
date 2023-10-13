using System.Collections;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class TestNeutrinoFogVaclasAvgurMeridian : IEnumerable<object[]>
{
    private const int PlasmFuel = 1000000;
    private const int GravityFuel = 1000000;
    private const int AstronomicUnits = 100;

    private static readonly IList<Obstacles> _obstacles = new List<Obstacles>();
    public static IEnumerable<object[]> GetObjects
    {
        get
        {
            yield return new object[] { new Vaclas(PlasmFuel, GravityFuel), new Avgur(PlasmFuel, GravityFuel), new Meridian(PlasmFuel) };
        }
    }

    public static bool IsFinishedStep(StarShip? ship)
    {
        if (_obstacles.Count < 1) _obstacles.Add(new SpaceWhales());
        var neutrinoFog = new NeutrinoFog(_obstacles);

        return neutrinoFog.Stage(ship, AstronomicUnits);
    }

    IEnumerator<object[]> IEnumerable<object[]>.GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    public IEnumerator GetEnumerator()
    {
        return GetEnumerator();
    }

    [Theory]
    [MemberData(nameof(GetObjects), MemberType = typeof(TestNeutrinoFogVaclasAvgurMeridian))]
    public void AllObjectsAreOddWithMemberDataFromDataGenerator(Vaclas vaclas, Avgur avgur, Meridian meridian)
    {
        Assert.False(IsFinishedStep(vaclas));
        Assert.True(IsFinishedStep(avgur));
        Assert.True(IsFinishedStep(meridian));
    }
}