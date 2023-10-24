using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.RAM.Factory;
using Itmo.ObjectOrientedProgramming.Lab2.XMPProfile;

namespace Itmo.ObjectOrientedProgramming.Lab2.DataBase.RAMSelection;

public class RamSelection
{
    private const string NameFour = "DDR4-3200";
    private const int MemoryLimitsFour = 128;
    private const int RamFormFactorFour = 288;
    private const int VersionDDRFour = 4;
    private const int PowerFour = 10;

    private const string NameFive = "DDR5-1500";
    private const int MemoryLimitsFive = 128;
    private const int RamFormFactorFive = 288;
    private const int VersionDDRFive = 5;
    private const int PowerFive = 15;

    private List<RamFactory> ramSelections = new();

    public RamSelection()
    {
        ramSelections.Add(new DDR4Factory(
            NameFour,
            MemoryLimitsFour,
            new Xmp(20, 20, 20),
            RamFormFactorFour,
            VersionDDRFour,
            PowerFour));

        ramSelections.Add(new DDR5Factory(
            NameFive,
            MemoryLimitsFive,
            new Xmp(20, 12, 18),
            RamFormFactorFive,
            VersionDDRFive,
            PowerFive));
    }
}