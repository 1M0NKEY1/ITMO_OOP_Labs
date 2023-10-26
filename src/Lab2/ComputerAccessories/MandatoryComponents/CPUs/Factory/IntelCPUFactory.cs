using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.SocketTypeDir;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.Factory;

public class IntelCPUFactory : CPUFactory
{
    private readonly string _name;
    private readonly int _coreFrequency;
    private readonly int _cores;
    private readonly SocketTypes _socket;
    private readonly bool _integratedGraphics;
    private readonly int _supportedMemory;
    private readonly int _tdp;
    private readonly int _powerConsumption;

    public IntelCPUFactory(
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

    public override Cpu CreateCPU()
    {
        return new IntelCPU(
            _name,
            _coreFrequency,
            _cores,
            _socket,
            _integratedGraphics,
            _supportedMemory,
            _tdp,
            _powerConsumption);
    }
}