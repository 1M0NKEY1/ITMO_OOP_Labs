using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.XMPProfile;

public abstract class XmpProfile
{
    protected XmpProfile(int timingOne, int timingTwo, int timingThree)
    {
        var addedTimings = new List<int>
        {
            timingOne,
            timingTwo,
            timingThree,
        };

        Timings = addedTimings;
    }

    public IReadOnlyList<int>? Timings { get; protected set; }
    public int Voltage { get; }
    public int FrequencyXmpProfile { get; protected set; }
}