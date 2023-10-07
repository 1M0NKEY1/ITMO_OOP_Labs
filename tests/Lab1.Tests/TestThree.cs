using Itmo.ObjectOrientedProgramming.Lab1.Routes;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class TestThree
{
    public static bool IsFinishedRoute(int ship)
    {
        var route = new Route(true, 300, 300);
        if (route.Step(ship, (int)SelectEnvironment.NeutrinoFog, 1, 0, 300))
        {
            return true;
        }

        return false;
    }

    [Theory]
    [InlineData((int)SelectShip.Vaclas, (int)SelectShip.Avgur, (int)SelectShip.Meridian)]
    public void AllNumbersAreOddWithInlineData(int vaclas, int avgur, int meridian)
    {
        Assert.False(IsFinishedRoute(vaclas));
        Assert.True(IsFinishedRoute(avgur));
        Assert.True(IsFinishedRoute(meridian));
    }
}