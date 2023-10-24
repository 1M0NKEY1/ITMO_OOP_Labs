using Itmo.ObjectOrientedProgramming.Lab2.XMPProfile;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.RAM.Factory;

public class DDR4Factory : RamFactory
{
    private readonly string _name;
    private readonly int _memoryLimits;
    private readonly XmpProfile _availableXMP;
    private readonly int _ramFormFactor;
    private readonly int _versionDDR;
    private readonly int _ramPower;

    public DDR4Factory(
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

    public override Ram CreateRam()
    {
        return new DDR4(
            _name,
            _memoryLimits,
            _availableXMP,
            _ramFormFactor,
            _versionDDR,
            _ramPower);
    }
}