namespace Itmo.ObjectOrientedProgramming.Lab1.Routes;

public class NumOfSuperFog : SelectEnvironment
{
    private int Fog { get; set; }

    public override void SetNumOfEnvironment()
    {
        Fog = 2;
    }

    public override int GetNumOfEnvironment()
    {
        SetNumOfEnvironment();
        return Fog;
    }
}