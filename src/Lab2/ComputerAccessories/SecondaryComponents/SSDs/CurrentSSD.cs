using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.SSDs.InputTypeDir;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.SSDs;

public class CurrentSSD : SSD
{
    private readonly string _name;
    private readonly InputTypes _inputType;
    private readonly int _ssdMemory;
    private readonly int _maxSpeed;
    private readonly int _ssdPower;

    public CurrentSSD(string name, InputTypes inputType, int ssdMemory, int maxSpeed, int ssdPower)
    {
        _name = name;
        _inputType = inputType;
        _ssdMemory = ssdMemory;
        _maxSpeed = maxSpeed;
        _ssdPower = ssdPower;
    }

    public override string Name => _name;
    public override InputTypes InputType => _inputType;
    public override int SSDMemory => _ssdMemory;
    public override int MaxSpeed => _maxSpeed;
    public override int SSDPower => _ssdPower;
}