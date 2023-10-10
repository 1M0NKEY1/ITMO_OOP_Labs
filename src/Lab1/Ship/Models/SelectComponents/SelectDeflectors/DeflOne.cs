namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

public class DeflOne : SelectDeflector
{
    private int DeflectorOne { get; set; }

    public override void SetNumOfDeflector()
    {
        DeflectorOne = 1;
    }

    public override int GetNumOfDeflector()
    {
        SetNumOfDeflector();
        return DeflectorOne;
    }
}