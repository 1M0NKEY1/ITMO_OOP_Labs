namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

public class HullOne : SelectHull
{
    private int HOne { get; set; }

    public override void SetNumOfHull()
    {
        HOne = 1;
    }

    public override int GetNumOfHull()
    {
        SetNumOfHull();
        return HOne;
    }
}