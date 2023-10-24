using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.SocketType;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU;

public abstract class CPU
{
    public abstract string CPUName { get; }
    public abstract int CoreFrequency { get; }
    public abstract int Cores { get; }
    public abstract SocketTypes Socket { get; }
    public abstract bool IntegratedGraphics { get; }
    public abstract int SupportedMemory { get; }
    public abstract int TDP { get; }
    public abstract int PowerConsumption { get; }
}