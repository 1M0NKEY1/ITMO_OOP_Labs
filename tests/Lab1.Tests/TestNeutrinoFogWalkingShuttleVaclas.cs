using Itmo.ObjectOrientedProgramming.Lab1.Routes;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class TestNeutrinoFogWalkingShuttleVaclas
{
    private static readonly NumOfNeutrinoFog _numOfNeutrinoFog = new();
    public static bool IsFinishedRoute(int ship)
    {
        var route = new Route(true, 10000, 300);
        return route.Step(ship, _numOfNeutrinoFog.GetNumOfEnvironment(), 0, 0, 300);
    }

    public static bool IsFinishedRouteTwo(int ship)
    {
        var route = new Route(true, 10000, 300);
        return route.Step(ship, _numOfNeutrinoFog.GetNumOfEnvironment(), 0, 0, 300);
    }

    [Theory]
    [InlineData(1, 2)]
    public void AllNumbersAreOddWithInlineData(int walkingShuttle, int vaclas)
    {
        Assert.False(IsFinishedRoute(walkingShuttle));
        Assert.True(IsFinishedRouteTwo(vaclas));
    }
}