namespace Itmo.ObjectOrientedProgramming.Lab1.Fuel;

public class FuelExchange : MiningBuild
{
    private const int _rateForPlasm = 10;
    private const int _rateForGravity = 15;

    private const int Extracted = 1000;

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
        ExtractedPlasmFuel = Extracted;
        int price = ExtractedPlasmFuel * _rateForPlasm;

        return price;
    }

    private int PriceOfGravityFuel()
    {
        ExtractedGravityFuel = Extracted;
        int price = ExtractedGravityFuel * _rateForGravity;

        return price;
    }
}