using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.ChipSetDir;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.SataTypeDir;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.SocketTypeDir;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards.PCIVersionDir;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.Motherboards.MotherBoardFactory;

public class CurrentMotherBoardFactory : MotherBoardFactory
{
    private readonly string _name;
    private readonly SocketTypes _socket;
    private readonly PCIVersions _pci;
    private readonly SataType _sata;
    private readonly Chip _chipSet;
    private readonly int _ddr;
    private readonly int _ramTableCount;
    private readonly int _formFactorMother;
    private readonly int _motheBoardBios;

    public CurrentMotherBoardFactory(
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
        _motheBoardBios = motherBoardBios;
    }

    public override MotherBoard CreateMotherBoard()
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
            _motheBoardBios);
    }
}