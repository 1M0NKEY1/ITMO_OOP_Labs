namespace Itmo.ObjectOrientedProgramming.Lab2.XMPProfile;

public class JedecEight : XmpProfile
{
    private const int FrequencyEight = 1066;

    public JedecEight(int timingOne, int timingTwo, int timingThree)
        : base(timingOne, timingTwo, timingThree)
    {
        FrequencyXmpProfile = FrequencyEight;
    }
}