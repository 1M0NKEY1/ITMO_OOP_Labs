namespace Itmo.ObjectOrientedProgramming.Lab1.Routes;

public class ShipAvgur : SelectShip
{
    private int Avgur { get; set; }

    public override void SetNumOfShip()
    {
        Avgur = 5;
    }

    public override int GetNumOfShip()
    {
        SetNumOfShip();
        return Avgur;
    }
}