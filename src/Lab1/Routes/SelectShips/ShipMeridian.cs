namespace Itmo.ObjectOrientedProgramming.Lab1.Routes;

public class ShipMeridian : SelectShip
{
    private int Meridian { get; set; }

    public override void SetNumOfShip()
    {
        Meridian = 3;
    }

    public override int GetNumOfShip()
    {
        SetNumOfShip();
        return Meridian;
    }
}