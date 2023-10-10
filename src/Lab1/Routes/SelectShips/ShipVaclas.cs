namespace Itmo.ObjectOrientedProgramming.Lab1.Routes;

public class ShipVaclas : SelectShip
{
    private int Vaclas { get; set; }

    public override void SetNumOfShip()
    {
        Vaclas = 2;
    }

    public override int GetNumOfShip()
    {
        SetNumOfShip();
        return Vaclas;
    }
}