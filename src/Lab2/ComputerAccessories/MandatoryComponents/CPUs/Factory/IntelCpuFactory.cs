using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.SocketTypeDir;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.Factory;

public class IntelCpuFactory : CPUFactoryBase
{
    private string? _name;
    private int _coreFrequency;
    private int _cores;
    private SocketTypes? _socket;
    private bool _integratedGraphics;
    private int _supportedMemory;
    private int _tdp;
    private int _powerConsumption;

    public void NewInstance(
        string? name,
        int coreFrequency,
        int cores,
        SocketTypes? socket,
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

    public override CpuBase Create()
    {
        return new IntelCpu(
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