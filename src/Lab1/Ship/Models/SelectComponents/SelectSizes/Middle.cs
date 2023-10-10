namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

public class Middle : SelectSize
{
    private int TypeMiddle { get; set; }

    public override void SetNumOfSize()
    {
        TypeMiddle = 1;
    }

    public override int GetNumOfSize()
    {
        SetNumOfSize();
        return TypeMiddle;
    }
}