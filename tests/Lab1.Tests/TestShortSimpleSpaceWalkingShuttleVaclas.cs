using Itmo.ObjectOrientedProgramming.Lab1.Routes;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class TestShortSimpleSpaceWalkingShuttleVaclas
{
    private readonly NumOfSimpleSpace _simpleSpace = new();
    public bool IsFinishedRoute(int shipOne, int shipTwo)
    {
        var route = new Route(false, 1000000, 300);
        var routeTwo = new Route(false, 1000000, 300);
        if (route.CostOfStep(_simpleSpace.GetNumOfEnvironment(), 100, shipOne) < routeTwo.CostOfStep(_simpleSpace.GetNumOfEnvironment(), 100, shipTwo))
        {
            return true;
        }

        return false;
    }

    [Theory]
    [InlineData(1, 2)]
    public void AllNumbersAreOddWithInlineData(int walkingShuttle, int vaclas)
    {
        Assert.True(IsFinishedRoute(walkingShuttle, vaclas));
    }
}