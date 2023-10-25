using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.ChipSetDir;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.SataTypeDir;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.SocketTypeDir;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards.PCIVersionDir;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.Motherboards;

public class CurrentMotherBoard : MotherBoard
{
    private readonly string _name;
    private readonly SocketTypes _socket;
    private readonly PCIVersions _pci;
    private readonly SataType _sata;
    private readonly Chip _chipSet;
    private readonly int _ddr;
    private readonly int _ramTableCount;
    private readonly int _formFactorMother;
    private readonly int _motherBoardBios;

    public CurrentMotherBoard(
        string name,
        SocketTypes socket,
        PCIVersions pci,
        SataType sata,
        Chip chipSet,
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

    public override string Name => _name;
    public override SocketTypes Socket => _socket;
    public override PCIVersions Pci => _pci;
    public override SataType Sata => _sata;
    public override Chip ChipSet => _chipSet;
    public override int DDR => _ddr;
    public override int RamTableCount => _ramTableCount;
    public override int FormFactorMother => _formFactorMother;
    public override int MotherBoardBios => _motherBoardBios;
}