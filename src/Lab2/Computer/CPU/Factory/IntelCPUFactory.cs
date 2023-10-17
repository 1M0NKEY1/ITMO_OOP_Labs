using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.SocketType;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.Factory;

public class IntelCPUFactory : CPUFactory
{
    private readonly int _coreFrequency;
    private readonly int _cores;
    private readonly SocketTypes _socket;
    private readonly bool _integratedGraphics;
    private readonly string _supportedMemory;
    private readonly string _tdp;
    private readonly int _powerConsumption;

    public IntelCPUFactory(int coreFrequency, int cores, SocketTypes socket, bool integratedGraphics, string supportedMemory, string tdp, int powerConsumption)
    {
        _coreFrequency = coreFrequency;
        _cores = cores;
        _socket = socket;
        _integratedGraphics = integratedGraphics;
        _supportedMemory = supportedMemory;
        _tdp = tdp;
        _powerConsumption = powerConsumption;
    }

    public override CPU CreateCPU()
    {
        return new IntelCPU(_coreFrequency, _cores, _socket, _integratedGraphics, _supportedMemory, _tdp, _powerConsumption);
    }
}