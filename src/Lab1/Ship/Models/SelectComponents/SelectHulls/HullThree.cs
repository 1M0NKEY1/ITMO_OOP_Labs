namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

public class HullThree : SelectHull
{
    private int HThree { get; set; }

    public override void SetNumOfHull()
    {
        HThree = 3;
    }

    public override int GetNumOfHull()
    {
        SetNumOfHull();
        return HThree;
    }
}