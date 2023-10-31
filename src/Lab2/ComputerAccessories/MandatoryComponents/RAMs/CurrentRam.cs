using Itmo.ObjectOrientedProgramming.Lab2.Prototype;
using Itmo.ObjectOrientedProgramming.Lab2.XMPProfile;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.RAM;

public class CurrentRam : Ram, IPrototype<CurrentRam>
{
    private int _memoryLimits;
    private XmpProfile _availableXMP;
    private int _ramFormFactor;
    private int _versionDDR;
    private int _ramPower;
    private string _name;

    public CurrentRam(
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
    public CurrentRam Clone()
    {
        return new CurrentRam(
            _name,
            _memoryLimits,
            _availableXMP,
            _ramFormFactor,
            _versionDDR,
            _ramPower);
    }

    public CurrentRam SetName(string name)
    {
        CurrentRam cloneRam = Clone();
        _name = name;

        return cloneRam;
    }

    public CurrentRam SetMemoryLimits(int memory)
    {
        CurrentRam cloneRam = Clone();
        _memoryLimits = memory;

        return cloneRam;
    }

    public CurrentRam SetXmp(XmpProfile xmp)
    {
        CurrentRam cloneRam = Clone();
        _availableXMP = xmp;

        return cloneRam;
    }

    public CurrentRam SetRamFormFactor(int formFactor)
    {
        CurrentRam cloneRam = Clone();
        _ramFormFactor = formFactor;

        return cloneRam;
    }

    public CurrentRam SetDDRVersion(int ddr)
    {
        CurrentRam cloneRam = Clone();
        _versionDDR = ddr;

        return cloneRam;
    }

    public CurrentRam SetPower(int power)
    {
        CurrentRam cloneRam = Clone();
        _ramPower = power;

        return cloneRam;
    }
}