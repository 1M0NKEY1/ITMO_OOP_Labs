using Itmo.ObjectOrientedProgramming.Lab2.Computer.CoolingSystem;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.Motherboards;
using Itmo.ObjectOrientedProgramming.Lab2.Prototype;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.ComputerCase;

public class ComputerCase : ComputerCasesBase, IPrototype<ComputerCase>
{
    private int _length;
    private int _width;
    private int _motherboardFormFactor;
    private int _caseDimensions;
    private string? _name;

    public ComputerCase(
        string? name,
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

    public override string? Name => _name;
    public override int VideoCardLength => _length;
    public override int VideoCardWidth => _width;
    public override int MotherboardFormFactor => _motherboardFormFactor;
    public override int CaseDimensions => _caseDimensions;

    public override bool AvailableMotherBoardForCase(MotherBoardBase motherBoardBase)
    {
        return motherBoardBase.FormFactorMother.Equals(_motherboardFormFactor);
    }

    public override bool AvailableCoolingSystemForCase(CoolingSystemsBase coolingSystemsBase)
    {
        return coolingSystemsBase.CoolingDimensions < _width;
    }

    public ComputerCase Clone()
    {
        return new ComputerCase(
            _name,
            _length,
            _width,
            _motherboardFormFactor,
            _caseDimensions);
    }

    public ComputerCase CloneWithNewName(string? name)
    {
        ComputerCase cloneCase = Clone();
        _name = name;

        return cloneCase;
    }

    public ComputerCase CloneWithNewLength(int length)
    {
        ComputerCase cloneCase = Clone();
        _length = length;

        return cloneCase;
    }

    public ComputerCase CloneWithNewWidth(int width)
    {
        ComputerCase cloneCase = Clone();
        _width = width;

        return cloneCase;
    }

    public ComputerCase CloneWithNewMotherboardFormFactor(int motherboardFormFactor)
    {
        ComputerCase cloneCase = Clone();
        _motherboardFormFactor = motherboardFormFactor;

        return cloneCase;
    }

    public ComputerCase CloneWithNewCaseDimension(int dimension)
    {
        ComputerCase cloneCase = Clone();
        _caseDimensions = dimension;

        return cloneCase;
    }
}