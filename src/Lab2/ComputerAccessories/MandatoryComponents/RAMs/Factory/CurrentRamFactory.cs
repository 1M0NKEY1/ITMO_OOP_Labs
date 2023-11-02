using Itmo.ObjectOrientedProgramming.Lab2.XMPProfile;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.RAM.Factory;

public class CurrentRamFactory : RamFactory
{
    private string? _name;
    private int _memoryLimits;
    private XmpProfile? _availableXMP;
    private int _ramFormFactor;
    private int _versionDDR;
    private int _ramPower;

    public void NewInstance(
        string? name,
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

    public override Ram Create()
    {
        return new CurrentRam(
            _name,
            _memoryLimits,
            _availableXMP,
            _ramFormFactor,
            _versionDDR,
            _ramPower);
    }
}