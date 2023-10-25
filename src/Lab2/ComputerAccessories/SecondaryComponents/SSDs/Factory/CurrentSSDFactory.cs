using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.SSDs.InputTypeDir;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.SSDs.Factory;

public class CurrentSSDFactory : SSDFactory
{
    private readonly string _name;
    private readonly InputTypes _inputType;
    private readonly int _ssdMemory;
    private readonly int _maxSpeed;
    private readonly int _ssdPower;

    public CurrentSSDFactory(string name, InputTypes inputType, int ssdMemory, int maxSpeed, int ssdPower)
    {
        _name = name;
        _inputType = inputType;
        _ssdMemory = ssdMemory;
        _maxSpeed = maxSpeed;
        _ssdPower = ssdPower;
    }

    public override SSD CreateSSD()
    {
        return new CurrentSSD(_name, _inputType, _ssdMemory, _maxSpeed, _ssdPower);
    }
}