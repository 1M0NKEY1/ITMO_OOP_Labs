using Itmo.ObjectOrientedProgramming.Lab2.Computer.CoolingSystem;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.Motherboards;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.ComputerCase;

public class CurrentComputerCase : ComputerCases
{
    private readonly string _name;
    private readonly int _length;
    private readonly int _width;
    private readonly int _motherboardFormFactor;
    private readonly int _caseDimensions;

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
        return motherBoard.FormFactorMother < _motherboardFormFactor;
    }

    public override bool AvailableCoolingSystemForCase(CoolingSystems coolingSystems)
    {
        return coolingSystems.CoolingDimensions < _width;
    }
}