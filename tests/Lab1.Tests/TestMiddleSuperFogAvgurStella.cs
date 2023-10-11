using Itmo.ObjectOrientedProgramming.Lab1.Routes;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class TestMiddleSuperFogAvgurStella
{
    private static readonly NumOfSuperFog _numOfSuperFog = new();
    public static bool IsFinishedRoute(int ship)
    {
        var route = new Route(true, 10000, 300);
        return route.Step(ship, _numOfSuperFog.GetNumOfEnvironment(), 0, 0, 300);
    }

    [Theory]
    [InlineData(5, 4)]
    public void AllNumbersAreOddWithInlineData(int avgur, int stella)
    {
        Assert.False(IsFinishedRoute(avgur));
        Assert.True(IsFinishedRoute(stella));
    }
}