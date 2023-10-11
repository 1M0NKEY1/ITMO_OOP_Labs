using Itmo.ObjectOrientedProgramming.Lab1.Routes;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class TestVaclasWithAndWithoutPhoton
{
    private readonly NumOfSuperFog _numOfSuperFog = new();
    public bool IsFinishedRoute(int ship)
    {
        var route = new Route(false, 300, 300);
        if (!route.Step(ship, _numOfSuperFog.GetNumOfEnvironment(), 1, 0, 100))
        {
            return true;
        }

        return false;
    }

    public bool IsFinishedRouteTwo(int ship)
    {
        var routeTwo = new Route(true, 300, 300);
        if (routeTwo.Step(ship, _numOfSuperFog.GetNumOfEnvironment(), 1, 0, 100))
        {
            return true;
        }

        return false;
    }

    [Theory]
    [InlineData(2, 2)]
    public void AllNumbersAreOddWithInlineData(int vaclasNoPhoton, int vaclasYesPhoton)
    {
        Assert.True(IsFinishedRoute(vaclasNoPhoton));
        Assert.True(IsFinishedRouteTwo(vaclasYesPhoton));
    }
}