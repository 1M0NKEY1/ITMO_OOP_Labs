namespace Itmo.ObjectOrientedProgramming.Lab1.Fuel;

public class FuelExchange : MiningBuild
{
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
        int price;
        if (ExtractedPlasmFuel < 1000)
        {
            price = 10 * ExtractedPlasmFuel;
        }
        else
        {
            price = 15 * ExtractedPlasmFuel;
        }

        return price;
    }

    private int PriceOfGravityFuel()
    {
        int price;
        if (ExtractedGravityFuel < 1000)
        {
            price = 20 * ExtractedGravityFuel;
        }
        else
        {
            price = 25 * ExtractedGravityFuel;
        }

        return price;
    }
}