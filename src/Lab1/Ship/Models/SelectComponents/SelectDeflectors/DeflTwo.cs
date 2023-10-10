namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

public class DeflTwo : SelectDeflector
{
    private int DeflectorTwo { get; set; }

    public override void SetNumOfDeflector()
    {
        DeflectorTwo = 2;
    }

    public override int GetNumOfDeflector()
    {
        SetNumOfDeflector();
        return DeflectorTwo;
    }
}