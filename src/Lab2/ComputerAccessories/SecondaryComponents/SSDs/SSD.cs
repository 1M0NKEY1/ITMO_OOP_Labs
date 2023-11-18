using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.SSDs.InputTypeDir;
using Itmo.ObjectOrientedProgramming.Lab2.Prototype;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.SSDs;

public class SSD : SSDBase, IPrototype<SSD>
{
    private InputTypes? _inputType;
    private int _ssdMemory;
    private int _maxSpeed;
    private int _ssdPower;
    private string? _name;

    public SSD(string? name, InputTypes? inputType, int ssdMemory, int maxSpeed, int ssdPower)
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
    public SSD Clone()
    {
        return new SSD(_name, _inputType, _ssdMemory, _maxSpeed, _ssdPower);
    }

    public SSD CloneWithNewName(string? name)
    {
        SSD cloneSsd = Clone();
        _name = name;

        return cloneSsd;
    }

    public SSD CloneWithNewInputType(InputTypes? inputTypes)
    {
        SSD cloneSsd = Clone();
        _inputType = inputTypes;

        return cloneSsd;
    }

    public SSD CloneWithNewMemory(int memory)
    {
        SSD cloneSsd = Clone();
        _ssdMemory = memory;

        return cloneSsd;
    }

    public SSD CloneWithNewMaxSpeed(int speed)
    {
        SSD cloneSsd = Clone();
        _maxSpeed = speed;

        return cloneSsd;
    }

    public SSD CloneWithNewPower(int power)
    {
        SSD cloneSsd = Clone();
        _ssdPower = power;

        return cloneSsd;
    }
}