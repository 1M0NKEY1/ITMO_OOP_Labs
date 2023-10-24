using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.SocketType;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.RAM;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.BIOS;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.Motherboards;

public abstract class MotherBoard
{
    public abstract SocketTypes Socket { get; }
    public abstract int Pci { get; }
    public abstract int Sata { get; }
    public abstract object ChipSet { get; }
    public abstract Ram DDR { get; }
    public abstract int RamTableCount { get; }
    public abstract int FormFactorMother { get; }
    public abstract Bios MotherBoardBios { get; }
}