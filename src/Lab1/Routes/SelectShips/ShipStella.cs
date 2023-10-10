namespace Itmo.ObjectOrientedProgramming.Lab1.Routes;

public class ShipStella : SelectShip
{
    private int Stella { get; set; }

    public override void SetNumOfShip()
    {
        Stella = 4;
    }

    public override int GetNumOfShip()
    {
        SetNumOfShip();
        return Stella;
    }
}