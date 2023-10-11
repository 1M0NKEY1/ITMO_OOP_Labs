namespace Itmo.ObjectOrientedProgramming.Lab1.Routes;

public class NumOfSimpleSpace : SelectEnvironment
{
    private int Space { get; set; }

    public override void SetNumOfEnvironment()
    {
        Space = 1;
    }

    public override int GetNumOfEnvironment()
    {
        SetNumOfEnvironment();
        return Space;
    }
}