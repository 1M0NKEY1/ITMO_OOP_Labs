using System.Collections;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class TestMiddleSuperFogVaclasPhoton : IEnumerable<object[]>
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
            yield return new object[] { new Vaclas(PlasmFuel, GravityFuel) };
        }
    }

    public static bool IsFinishedStep(StarShip? ship)
    {
        _obstacles.Add(new Flashes());

        var superFog = new SuperFog(_obstacles);
        if (ship != null)
        {
            ship.Photon = PhotonOn;
        }

        return superFog.Stage(ship, AstronomicUnits);
    }

    public static bool IsFinishedStepTwo(StarShip? ship)
    {
        _obstacles.Add(new Flashes());

        var superFog = new SuperFog(_obstacles);

        return superFog.Stage(ship, AstronomicUnits);
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
    [MemberData(nameof(GetObjects), MemberType = typeof(TestMiddleSuperFogVaclasPhoton))]
    public void AllObjectsAreOddWithMemberDataFromDataGenerator(Vaclas vaclas)
    {
        Assert.False(IsFinishedStep(vaclas));
        Assert.False(IsFinishedStepTwo(vaclas));
    }
}