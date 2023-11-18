namespace Itmo.ObjectOrientedProgramming.Lab2.XMPProfile;

public class JedecSix : XmpProfile
{
    private const int FrequencySix = 1037;

    public JedecSix(int timingOne, int timingTwo, int timingThree)
        : base(timingOne, timingTwo, timingThree)
    {
        FrequencyXmpProfile = FrequencySix;
    }
}