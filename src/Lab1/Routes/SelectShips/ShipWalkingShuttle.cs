namespace Itmo.ObjectOrientedProgramming.Lab1.Routes;

public class ShipWalkingShuttle : SelectShip
{
    private int WalkingShuttle { get; set; }

    public override void SetNumOfShip()
    {
        WalkingShuttle = 1;
    }

    public override int GetNumOfShip()
    {
        SetNumOfShip();
        return WalkingShuttle;
    }
}