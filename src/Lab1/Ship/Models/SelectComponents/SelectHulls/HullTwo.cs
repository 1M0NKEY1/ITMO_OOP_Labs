namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

public class HullTwo : SelectHull
{
    private int HTwo { get; set; }

    public override void SetNumOfHull()
    {
        HTwo = 2;
    }

    public override int GetNumOfHull()
    {
        SetNumOfHull();
        return HTwo;
    }
}