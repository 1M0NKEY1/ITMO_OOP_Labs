namespace Itmo.ObjectOrientedProgramming.Lab1.Routes;

public class NumOfNeutrinoFog : SelectEnvironment
{
    private int NeutFog { get; set; }

    public override void SetNumOfEnvironment()
    {
        NeutFog = 3;
    }

    public override int GetNumOfEnvironment()
    {
        SetNumOfEnvironment();
        return NeutFog;
    }
}