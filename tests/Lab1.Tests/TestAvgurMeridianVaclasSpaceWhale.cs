using Itmo.ObjectOrientedProgramming.Lab1.Routes;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class TestAvgurMeridianVaclasSpaceWhale
{
    private readonly NFog _nFog = new();

    private readonly ShipAvgur _shipAvgur = new();
    private readonly ShipMeridian _shipMeridian = new();
    private readonly ShipVaclas _shipVaclas = new();
    public bool IsFinishedRoute(int ship)
    {
        var route = new Route(true, 300, 300);
        if (route.Step(ship, _nFog.GetNumOfEnvironment(), 1, 0, 300))
        {
            return true;
        }

        return false;
    }

    [Theory]
    [InlineData(_ship, (int)SelectShip.Avgur, (int)SelectShip.Meridian)]
    public void AllNumbersAreOddWithInlineData(int vaclas, int avgur, int meridian)
    {
        Assert.False(IsFinishedRoute(vaclas));
        Assert.True(IsFinishedRoute(avgur));
        Assert.True(IsFinishedRoute(meridian));
    }
}