using Itmo.ObjectOrientedProgramming.Lab1.Routes;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class TestAvgurMeridianVaclasSpaceWhale
{
    private static readonly NumOfNeutrinoFog _numOfNeutrinoFog = new();
    public static bool IsFinishedRoute(int ship)
    {
        var route = new Route(true, 300, 300);
        if (route.Step(ship, _numOfNeutrinoFog.GetNumOfEnvironment(), 1, 0, 300))
        {
            return true;
        }

        return false;
    }

    [Theory]
    [InlineData(2, 5, 3)]
    public void AllNumbersAreOddWithInlineData(int vaclas, int avgur, int meridian)
    {
        Assert.False(IsFinishedRoute(vaclas));
        Assert.True(IsFinishedRoute(avgur));
        Assert.True(IsFinishedRoute(meridian));
    }
}