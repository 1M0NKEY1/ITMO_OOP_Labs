using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.SocketType;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU;

public class IntelCPU : CPU
{
    private readonly int _coreFrequency;
    private readonly int _cores;
    private readonly SocketTypes _socket;
    private readonly bool _integratedGraphics;
    private readonly string _supportedMemory;
    private readonly string _tdp;
    private readonly int _powerConsumption;

    public IntelCPU(int coreFrequency, int cores, SocketTypes socket, bool integratedGraphics, string supportedMemory, string tdp, int powerConsumption)
    {
        _coreFrequency = coreFrequency;
        _cores = cores;
        _socket = socket;
        _integratedGraphics = integratedGraphics;
        _supportedMemory = supportedMemory;
        _tdp = tdp;
        _powerConsumption = powerConsumption;
    }

    public override int CoreFrequency => _coreFrequency;
    public override int Cores => _cores;
    public override SocketTypes Socket => _socket;
    public override bool IntegratedGraphics => _integratedGraphics;
    public override string SupportedMemory => _supportedMemory;
    public override string TDP => _tdp;
    public override int PowerConsumption => _powerConsumption;
}