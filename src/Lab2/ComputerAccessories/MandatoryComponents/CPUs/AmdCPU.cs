using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.SocketType;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU;

public class AmdCPU : CPU
{
    private readonly string _name;
    private readonly int _coreFrequency;
    private readonly int _cores;
    private readonly SocketTypes _socket;
    private readonly bool _integratedGraphics;
    private readonly int _supportedMemory;
    private readonly int _tdp;
    private readonly int _powerConsumption;

    public AmdCPU(
        string name,
        int coreFrequency,
        int cores,
        SocketTypes socket,
        bool integratedGraphics,
        int supportedMemory,
        int tdp,
        int powerConsumption)
    {
        _name = name;
        _coreFrequency = coreFrequency;
        _cores = cores;
        _socket = socket;
        _integratedGraphics = integratedGraphics;
        _supportedMemory = supportedMemory;
        _tdp = tdp;
        _powerConsumption = powerConsumption;
    }

    public override string CPUName => _name;
    public override int CoreFrequency => _coreFrequency;
    public override int Cores => _cores;
    public override SocketTypes Socket => _socket;
    public override bool IntegratedGraphics => _integratedGraphics;
    public override int SupportedMemory => _supportedMemory;
    public override int TDP => _tdp;
    public override int PowerConsumption => _powerConsumption;
}