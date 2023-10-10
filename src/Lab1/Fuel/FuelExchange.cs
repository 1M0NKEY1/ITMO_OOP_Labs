namespace Itmo.ObjectOrientedProgramming.Lab1.Fuel;

public class FuelExchange : MiningBuild
{
    private const int _rateForPlasm = 10;
    private const int _rateForGravity = 15;

    public int ExchangeCostOfPlasmFuel(int astronomicUnits)
    {
        return astronomicUnits * PriceOfPlasmFuel();
    }

    public int ExchangeCostOfGravityFuel(int megaLitres)
    {
        return megaLitres * PriceOfGravityFuel();
    }

    private int PriceOfPlasmFuel()
    {
        int price = ExtractedPlasmFuel * _rateForPlasm;

        return price;
    }

    private int PriceOfGravityFuel()
    {
        int price = ExtractedGravityFuel * _rateForGravity;

        return price;
    }
}