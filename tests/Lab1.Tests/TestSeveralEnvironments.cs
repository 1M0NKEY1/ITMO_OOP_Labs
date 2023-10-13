using System.Collections;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Ship.Models;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class TestSeveralEnvironments : IEnumerable<object[]>
{
    private const int PlasmFuel = 100000000;
    private const int GravityFuel = 1000000;
    private const int AstronomicUnits = 100;

    private static readonly IList<Obstacles> _obstacles = new List<Obstacles>();
    public static IEnumerable<object[]> GetObjects
    {
        get
        {
            yield return new object[] { new Avgur(PlasmFuel, GravityFuel) };
        }
    }

    public static bool IsFinishedStepOne(StarShip? ship)
    {
        var neutrinoFog = new NeutrinoFog(_obstacles);

        return neutrinoFog.Stage(ship, AstronomicUnits);
    }

    public static bool IsFinishedStepTwo(StarShip? ship)
    {
        var simpleSpace = new SimpleSpace(_obstacles);

        return simpleSpace.Stage(ship, AstronomicUnits);
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
    [MemberData(nameof(GetObjects), MemberType = typeof(TestSeveralEnvironments))]
    public void AllObjectsAreOddWithMemberDataFromDataGenerator(Avgur avgur)
    {
        Assert.True(IsFinishedStepOne(avgur));
        Assert.True(IsFinishedStepTwo(avgur));
    }
}