using Itmo.ObjectOrientedProgramming.Lab2.Computer.CoolingSystem;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.Motherboards;
using Itmo.ObjectOrientedProgramming.Lab2.Prototype;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.ComputerCase;

public class CurrentComputerCase : ComputerCases, IPrototype<CurrentComputerCase>
{
    private int _length;
    private int _width;
    private int _motherboardFormFactor;
    private int _caseDimensions;
    private string _name;

    public CurrentComputerCase(
        string name,
        int length,
        int width,
        int motherboardFormFactor,
        int caseDimensions)
    {
        _name = name;
        _length = length;
        _width = width;
        _motherboardFormFactor = motherboardFormFactor;
        _caseDimensions = caseDimensions;
    }

    public override string Name => _name;
    public override int VideoCardLength => _length;
    public override int VideoCardWidth => _width;
    public override int MotherboardFormFactor => _motherboardFormFactor;
    public override int CaseDimensions => _caseDimensions;

    public override bool AvailableMotherBoardForCase(MotherBoard motherBoard)
    {
        return motherBoard.FormFactorMother.Equals(_motherboardFormFactor);
    }

    public override bool AvailableCoolingSystemForCase(CoolingSystems coolingSystems)
    {
        return coolingSystems.CoolingDimensions < _width;
    }

    public CurrentComputerCase Clone()
    {
        return new CurrentComputerCase(
            _name,
            _length,
            _width,
            _motherboardFormFactor,
            _caseDimensions);
    }

    public CurrentComputerCase SetName(string name)
    {
        CurrentComputerCase cloneCase = Clone();
        _name = name;

        return cloneCase;
    }

    public CurrentComputerCase SetLength(int length)
    {
        CurrentComputerCase cloneCase = Clone();
        _length = length;

        return cloneCase;
    }

    public CurrentComputerCase SetWidth(int width)
    {
        CurrentComputerCase cloneCase = Clone();
        _width = width;

        return cloneCase;
    }

    public CurrentComputerCase SetMotherboardFormFactor(int motherboardFormFactor)
    {
        CurrentComputerCase cloneCase = Clone();
        _motherboardFormFactor = motherboardFormFactor;

        return cloneCase;
    }

    public CurrentComputerCase SetCaseDimension(int dimension)
    {
        CurrentComputerCase cloneCase = Clone();
        _caseDimensions = dimension;

        return cloneCase;
    }
}