using Itmo.ObjectOrientedProgramming.Lab2.Prototype;
using Itmo.ObjectOrientedProgramming.Lab2.XMPProfile;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.RAM;

public class Ram : RamBase, IPrototype<Ram>
{
    private int _memoryLimits;
    private XmpProfile? _availableXMP;
    private int _ramFormFactor;
    private int _versionDDR;
    private int _ramPower;
    private string? _name;

    public Ram(
        string? name,
        int memoryLimits,
        XmpProfile? availableXmp,
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

    public override string? Name => _name;
    public override int MemoryLimits => _memoryLimits;
    public override XmpProfile? AvailableXMP => _availableXMP;
    public override int RamFormFactor => _ramFormFactor;
    public override int VersionDDR => _versionDDR;
    public override int RamPower => _ramPower;
    public Ram Clone()
    {
        return new Ram(
            _name,
            _memoryLimits,
            _availableXMP,
            _ramFormFactor,
            _versionDDR,
            _ramPower);
    }

    public Ram CloneWithNewName(string? name)
    {
        Ram cloneRam = Clone();
        _name = name;

        return cloneRam;
    }

    public Ram CloneWithNewMemoryLimits(int memory)
    {
        Ram cloneRam = Clone();
        _memoryLimits = memory;

        return cloneRam;
    }

    public Ram CloneWithNewXmp(XmpProfile xmp)
    {
        Ram cloneRam = Clone();
        _availableXMP = xmp;

        return cloneRam;
    }

    public Ram CloneWithNewRamFormFactor(int formFactor)
    {
        Ram cloneRam = Clone();
        _ramFormFactor = formFactor;

        return cloneRam;
    }

    public Ram CloneWithNewDDRVersion(int ddr)
    {
        Ram cloneRam = Clone();
        _versionDDR = ddr;

        return cloneRam;
    }

    public Ram CloneWithNewPower(int power)
    {
        Ram cloneRam = Clone();
        _ramPower = power;

        return cloneRam;
    }
}