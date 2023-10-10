using Itmo.ObjectOrientedProgramming.Lab1.Routes;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class TestAvgurWalkingShuttleMiddleSuperFog
{
    public static bool IsFinishedRoute(int ship)
    {
        var route = new Route(false, 300, 300);
        return route.Step(ship, (int)SelectEnvironment.SuperFog, 0, 0, 300);
    }

    [Theory]
    [InlineData((int)SelectShip.WalkingShuttle, (int)SelectShip.Avgur)]
    public void AllNumbersAreOddWithInlineData(int walkingShuttle, int avgur)
    {
        Assert.False(IsFinishedRoute(walkingShuttle));
        Assert.False(IsFinishedRoute(avgur));
    }
}