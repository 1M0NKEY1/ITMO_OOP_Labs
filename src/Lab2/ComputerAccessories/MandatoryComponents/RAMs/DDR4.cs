using Itmo.ObjectOrientedProgramming.Lab2.XMPProfile;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.RAM;

public class DDR4 : Ram
{
    private readonly string _name;
    private readonly int _memoryLimits;
    private readonly XmpProfile _availableXMP;
    private readonly int _ramFormFactor;
    private readonly int _versionDDR;
    private readonly int _ramPower;

    public DDR4(
        string name,
        int memoryLimits,
        XmpProfile availableXmp,
        int ramFormFactor,
        int versionDdr,
        int ramPower)
    {
        _name = name;
        _memoryLimits = memoryLimits;
        _availableXMP = availableXmp;
        _ramFormFactor = ramFormFactor;
        _versionDDR = versionDdr;
        _ramPower = ramPower;
    }

    public override string Name => _name;
    public override int MemoryLimits => _memoryLimits;
    public override XmpProfile AvailableXMP => _availableXMP;
    public override int RamFormFactor => _ramFormFactor;
    public override int VersionDDR => _versionDDR;
    public override int RamPower => _ramPower;
}