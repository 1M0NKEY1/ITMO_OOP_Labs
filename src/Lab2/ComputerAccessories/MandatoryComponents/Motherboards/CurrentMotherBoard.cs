using Itmo.ObjectOrientedProgramming.Lab2.Computer.RAM;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.ChipSetDir;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.SataTypeDir;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.SocketTypeDir;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards.PCIVersionDir;
using Itmo.ObjectOrientedProgramming.Lab2.Prototype;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.Motherboards;

public class CurrentMotherBoard : MotherBoard, IPrototype<CurrentMotherBoard>
{
    private SocketTypes _socket;
    private PCIVersions _pci;
    private SataType _sata;
    private Chip _chipSet;
    private int _ddr;
    private int _ramTableCount;
    private int _formFactorMother;
    private int _motherBoardBios;
    private string _name;

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

    public override bool AvailableRamForMotherboard(Ram ram)
    {
        return ram.RamFormFactor == RamTableCount && ram.VersionDDR == _ddr;
    }

    public CurrentMotherBoard Clone()
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

    public CurrentMotherBoard SetName(string name)
    {
        CurrentMotherBoard cloneMotherboard = Clone();
        _name = name;

        return cloneMotherboard;
    }

    public CurrentMotherBoard SetSocket(SocketTypes socketTypes)
    {
        CurrentMotherBoard cloneMotherboard = Clone();
        _socket = socketTypes;

        return cloneMotherboard;
    }

    public CurrentMotherBoard SetPCI(PCIVersions pciVersions)
    {
        CurrentMotherBoard cloneMotherboard = Clone();
        _pci = pciVersions;

        return cloneMotherboard;
    }

    public CurrentMotherBoard SetSata(SataType sataType)
    {
        CurrentMotherBoard cloneMotherboard = Clone();
        _sata = sataType;

        return cloneMotherboard;
    }

    public CurrentMotherBoard SetChip(Chip chip)
    {
        CurrentMotherBoard cloneMotherboard = Clone();
        _chipSet = chip;

        return cloneMotherboard;
    }

    public CurrentMotherBoard SetDdr(int ddr)
    {
        CurrentMotherBoard cloneMotherboard = Clone();
        _ddr = ddr;

        return cloneMotherboard;
    }

    public CurrentMotherBoard SetRamTableCount(int ramTableCount)
    {
        CurrentMotherBoard cloneMotherboard = Clone();
        _ramTableCount = ramTableCount;

        return cloneMotherboard;
    }

    public CurrentMotherBoard SetMotherFormFactor(int formFactor)
    {
        CurrentMotherBoard cloneMotherboard = Clone();
        _formFactorMother = formFactor;

        return cloneMotherboard;
    }

    public CurrentMotherBoard SetMotherboardBios(int bios)
    {
        CurrentMotherBoard cloneMotherboard = Clone();
        _motherBoardBios = bios;

        return cloneMotherboard;
    }
}