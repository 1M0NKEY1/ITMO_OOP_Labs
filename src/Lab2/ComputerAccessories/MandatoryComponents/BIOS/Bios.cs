using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.BIOS;

public abstract class Bios
{
    public abstract int BiosType { get; }
    public abstract int BiosVersion { get; }
    public abstract bool AvailableCPU(CPU cpu);
}