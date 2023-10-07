using Itmo.ObjectOrientedProgramming.Lab1.Routes;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class TestTwo
{
    public static bool IsFinishedRoute(int ship)
    {
        var route = new Route(false, 300, 300);
        if (!route.Step(ship, (int)SelectEnvironment.SuperFog, 1, 0, 100))
        {
            return true;
        }

        return false;
    }

    public static bool IsFinishedRouteTwo(int ship)
    {
        var routeTwo = new Route(true, 300, 300);
        if (routeTwo.Step(ship, (int)SelectEnvironment.SuperFog, 1, 0, 100))
        {
            return true;
        }

        return false;
    }

    [Theory]
    [InlineData((int)SelectShip.Vaclas, (int)SelectShip.Vaclas)]
    public void AllNumbersAreOddWithInlineData(int vaclasNoPhoton, int vaclasYesPhoton)
    {
        Assert.True(IsFinishedRoute(vaclasNoPhoton));
        Assert.True(IsFinishedRouteTwo(vaclasYesPhoton));
    }
}