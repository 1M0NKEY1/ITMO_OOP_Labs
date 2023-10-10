namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

public class DeflThree : SelectDeflector
{
    private int DeflectorThree { get; set; }

    public override void SetNumOfDeflector()
    {
        DeflectorThree = 3;
    }

    public override int GetNumOfDeflector()
    {
        SetNumOfDeflector();
        return DeflectorThree;
    }
}