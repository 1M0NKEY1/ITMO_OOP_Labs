using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.SSDs.InputTypeDir;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.SSDs.Factory;

public class CurrentSSDFactory : SSDFactory
{
    private string? _name;
    private InputTypes? _inputType;
    private int _ssdMemory;
    private int _maxSpeed;
    private int _ssdPower;

    public void NewInstance(
        string? name,
        InputTypes? inputType,
        int ssdMemory,
        int maxSpeed,
        int ssdPower)
    {
        _name = name;
        _inputType = inputType;
        _ssdMemory = ssdMemory;
        _maxSpeed = maxSpeed;
        _ssdPower = ssdPower;
    }

    public override SSD Create()
    {
        return new CurrentSSD(_name, _inputType, _ssdMemory, _maxSpeed, _ssdPower);
    }
}