namespace Itmo.ObjectOrientedProgramming.Lab2.XMPProfile;

public class JedecSeven : XmpProfile
{
    private const int FrequencySeven = 1066;

    public JedecSeven(int timingOne, int timingTwo, int timingThree)
        : base(timingOne, timingTwo, timingThree)
    {
        FrequencyXmpProfile = FrequencySeven;
    }
}