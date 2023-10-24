using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.SocketType;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.RAM;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.BIOS;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.Motherboards.MotherBoardFactory;

public class CurrentMotherBoardFactory : MotherBoardFactory
{
    private readonly SocketTypes _socket;
    private readonly int _pci;
    private readonly int _sata;
    private readonly object _chipSet;
    private readonly Ram _ddr;
    private readonly int _ramTableCount;
    private readonly int _formFactorMother;
    private readonly Bios _motheBoardBios;

    public CurrentMotherBoardFactory(
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
        _motheBoardBios = motherBoardBios;
    }

    public override MotherBoard CreateMotherBoard()
    {
        return new CurrentMotherBoard(
            _socket,
            _pci,
            _sata,
            _chipSet,
            _ddr,
            _ramTableCount,
            _formFactorMother,
            _motheBoardBios);
    }
}