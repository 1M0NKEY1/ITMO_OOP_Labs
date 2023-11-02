using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.SSDs.InputTypeDir;
using Itmo.ObjectOrientedProgramming.Lab2.Prototype;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.SSDs;

public class CurrentSSD : SSD, IPrototype<CurrentSSD>
{
    private InputTypes? _inputType;
    private int _ssdMemory;
    private int _maxSpeed;
    private int _ssdPower;
    private string? _name;

    public CurrentSSD(string? name, InputTypes? inputType, int ssdMemory, int maxSpeed, int ssdPower)
    {
        _name = name;
        _inputType = inputType;
        _ssdMemory = ssdMemory;
        _maxSpeed = maxSpeed;
        _ssdPower = ssdPower;
    }

    public override string? Name => _name;
    public override InputTypes? InputType => _inputType;
    public override int SSDMemory => _ssdMemory;
    public override int MaxSpeed => _maxSpeed;
    public override int SSDPower => _ssdPower;
    public CurrentSSD Clone()
    {
        return new CurrentSSD(_name, _inputType, _ssdMemory, _maxSpeed, _ssdPower);
    }

    public CurrentSSD CloneWithNewName(string? name)
    {
        CurrentSSD cloneSsd = Clone();
        _name = name;

        return cloneSsd;
    }

    public CurrentSSD CloneWithNewInputType(InputTypes? inputTypes)
    {
        CurrentSSD cloneSsd = Clone();
        _inputType = inputTypes;

        return cloneSsd;
    }

    public CurrentSSD CloneWithNewMemory(int memory)
    {
        CurrentSSD cloneSsd = Clone();
        _ssdMemory = memory;

        return cloneSsd;
    }

    public CurrentSSD CloneWithNewMaxSpeed(int speed)
    {
        CurrentSSD cloneSsd = Clone();
        _maxSpeed = speed;

        return cloneSsd;
    }

    public CurrentSSD CloneWithNewPower(int power)
    {
        CurrentSSD cloneSsd = Clone();
        _ssdPower = power;

        return cloneSsd;
    }
}