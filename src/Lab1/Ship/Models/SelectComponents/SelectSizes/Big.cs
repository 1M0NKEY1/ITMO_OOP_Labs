namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Models.SelectComponents;

public class Big : SelectSize
{
    private int TypeBig { get; set; }

    public override void SetNumOfSize()
    {
        TypeBig = 1;
    }

    public override int GetNumOfSize()
    {
        SetNumOfSize();
        return TypeBig;
    }
}