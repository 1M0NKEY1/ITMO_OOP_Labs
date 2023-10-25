using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.ChipSetDir;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.SataTypeDir;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.SocketTypeDir;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards.PCIVersionDir;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.Motherboards;

public abstract class MotherBoard
{
    public abstract string Name { get; }
    public abstract SocketTypes Socket { get; }
    public abstract PCIVersions Pci { get; }
    public abstract SataType Sata { get; }
    public abstract Chip ChipSet { get; }
    public abstract int DDR { get; }
    public abstract int RamTableCount { get; }
    public abstract int FormFactorMother { get; }
    public abstract int MotherBoardBios { get; }
}