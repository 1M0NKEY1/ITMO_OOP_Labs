using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.SSDs.InputTypeDir;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.SSDs.Factory;

public class CurrentSSDFactory : SSDFactory
{
    private readonly InputTypes _inputType;
    private readonly int _ssdMemory;
    private readonly int _maxSpeed;
    private readonly int _ssdPower;

    public CurrentSSDFactory(InputTypes inputType, int ssdMemory, int maxSpeed, int ssdPower)
    {
        _inputType = inputType;
        _ssdMemory = ssdMemory;
        _maxSpeed = maxSpeed;
        _ssdPower = ssdPower;
    }

    public override SSD CreateSSD()
    {
        return new CurrentSSD(_inputType, _ssdMemory, _maxSpeed, _ssdPower);
    }
}