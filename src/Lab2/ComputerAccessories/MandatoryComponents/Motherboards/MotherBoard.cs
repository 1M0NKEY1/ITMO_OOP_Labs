using Itmo.ObjectOrientedProgramming.Lab2.Computer.RAM;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.ChipSetDir;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.SataTypeDir;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.SocketTypeDir;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards.PCIVersionDir;
using Itmo.ObjectOrientedProgramming.Lab2.Prototype;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.Motherboards;

public class MotherBoard : MotherBoardBase, IPrototype<MotherBoard>
{
    private SocketTypes? _socket;
    private PCIVersions? _pci;
    private SataType? _sata;
    private Chip? _chipSet;
    private int _ddr;
    private int _ramTableCount;
    private int _formFactorMother;
    private int _motherBoardBios;
    private string? _name;

    public MotherBoard(
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

    public override string? Name => _name;
    public override SocketTypes? Socket => _socket;
    public override PCIVersions? Pci => _pci;
    public override SataType? Sata => _sata;
    public override Chip? ChipSet => _chipSet;
    public override int DDR => _ddr;
    public override int RamTableCount => _ramTableCount;
    public override int FormFactorMother => _formFactorMother;
    public override int MotherBoardBios => _motherBoardBios;

    public override bool AvailableRamForMotherboard(RamBase ramBase)
    {
        return ramBase.RamFormFactor == RamTableCount && ramBase.VersionDDR == _ddr;
    }

    public MotherBoard Clone()
    {
        return new MotherBoard(
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

    public MotherBoard CloneWithNewName(string? name)
    {
        MotherBoard cloneMotherboard = Clone();
        _name = name;

        return cloneMotherboard;
    }

    public MotherBoard CloneWithNewSocket(SocketTypes? socketTypes)
    {
        MotherBoard cloneMotherboard = Clone();
        _socket = socketTypes;

        return cloneMotherboard;
    }

    public MotherBoard CloneWithNewPCI(PCIVersions? pciVersions)
    {
        MotherBoard cloneMotherboard = Clone();
        _pci = pciVersions;

        return cloneMotherboard;
    }

    public MotherBoard CloneWithNewSata(SataType? sataType)
    {
        MotherBoard cloneMotherboard = Clone();
        _sata = sataType;

        return cloneMotherboard;
    }

    public MotherBoard CloneWithNewChip(Chip? chip)
    {
        MotherBoard cloneMotherboard = Clone();
        _chipSet = chip;

        return cloneMotherboard;
    }

    public MotherBoard CloneWithNewDdr(int ddr)
    {
        MotherBoard cloneMotherboard = Clone();
        _ddr = ddr;

        return cloneMotherboard;
    }

    public MotherBoard CloneWithNewRamTableCount(int ramTableCount)
    {
        MotherBoard cloneMotherboard = Clone();
        _ramTableCount = ramTableCount;

        return cloneMotherboard;
    }

    public MotherBoard CloneWithNewMotherFormFactor(int formFactor)
    {
        MotherBoard cloneMotherboard = Clone();
        _formFactorMother = formFactor;

        return cloneMotherboard;
    }

    public MotherBoard CloneWithNewMotherboardBios(int bios)
    {
        MotherBoard cloneMotherboard = Clone();
        _motherBoardBios = bios;

        return cloneMotherboard;
    }
}