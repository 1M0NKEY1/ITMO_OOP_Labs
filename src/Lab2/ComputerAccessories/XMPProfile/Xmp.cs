namespace Itmo.ObjectOrientedProgramming.Lab2.XMPProfile;

public class Xmp : XmpProfile
{
    private const int XmpFrequency = 1600;

    public Xmp(int timingOne, int timingTwo, int timingThree)
        : base(timingOne, timingTwo, timingThree)
    {
        FrequencyXmpProfile = XmpFrequency;
    }
}