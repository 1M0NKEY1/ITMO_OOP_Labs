using Itmo.ObjectOrientedProgramming.Lab2.Computer.ComputerCase;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.SocketType;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.RAM;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.BIOS;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.Motherboards;

public class CurrentMotherBoard : MotherBoard
{
    private readonly SocketTypes _socket;
    private readonly int _pci;
    private readonly int _sata;
    private readonly object _chipSet;
    private readonly Ram _ddr;
    private readonly int _ramTableCount;
    private readonly int _formFactorMother;
    private readonly Bios _motherBoardBios;

    private readonly ComputerCases _computerCases;

    public CurrentMotherBoard(
        SocketTypes socket,
        int pci,
        int sata,
        object chipSet,
        Ram ddr,
        int ramTableCount,
        int formFactorMother,
        Bios motherBoardBios)
    {
        _socket = socket;
        _pci = pci;
        _sata = sata;
        _chipSet = chipSet;
        _ddr = ddr;
        _ramTableCount = ramTableCount;
        _formFactorMother = formFactorMother;
        _motherBoardBios = motherBoardBios;
    }

    public bool AvailableMotherboard()
    {
        return _formFactorMother == _computerCases.MotherboardFormFactor;
    }

    public override SocketTypes Socket => _socket;
    public override int Pci => _pci;
    public override int Sata => _sata;
    public override object ChipSet => _chipSet;
    public override Ram DDR => _ddr;
    public override int RamTableCount => _ramTableCount;
    public override int FormFactorMother => _formFactorMother;
    public override Bios MotherBoardBios => _motherBoardBios;
}