namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

public class Small : SelectSize
{
    private int TypeSmall { get; set; }

    public override void SetNumOfSize()
    {
        TypeSmall = 1;
    }

    public override int GetNumOfSize()
    {
        SetNumOfSize();
        return TypeSmall;
    }
}