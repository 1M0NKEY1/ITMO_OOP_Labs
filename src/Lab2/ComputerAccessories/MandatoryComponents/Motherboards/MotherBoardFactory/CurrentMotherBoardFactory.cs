using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.ChipSetDir;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.SataTypeDir;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.SocketTypeDir;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards.PCIVersionDir;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.Motherboards.MotherBoardFactory;

public class CurrentMotherBoardFactory : MotherBoardFactory
{
    private string? _name;
    private SocketTypes? _socket;
    private PCIVersions? _pci;
    private SataType? _sata;
    private Chip? _chipSet;
    private int _ddr;
    private int _ramTableCount;
    private int _formFactorMother;
    private int _motherBoardBios;

    public void NewInstance(
        string? name,
        SocketTypes? socket,
        PCIVersions? pci,
        SataType? sata,
        Chip? chipSet,
        int ddr,
        int ramTableCount,
        int formFactorMother,
        int motherBoardBios)
    {
        _name = name;
        _socket = socket;
        _pci = pci;
        _sata = sata;
        _chipSet = chipSet;
        _ddr = ddr;
        _ramTableCount = ramTableCount;
        _formFactorMother = formFactorMother;
        _motherBoardBios = motherBoardBios;
    }

    public override MotherBoard Create()
    {
        return new CurrentMotherBoard(
            _name,
            _socket,
            _pci,
            _sata,
            _chipSet,
            _ddr,
            _ramTableCount,
            _formFactorMother,
            _motherBoardBios);
    }
}