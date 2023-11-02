using Itmo.ObjectOrientedProgramming.Lab2.Computer.CoolingSystem;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.SocketType;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.SocketTypeDir;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.Motherboards;
using Itmo.ObjectOrientedProgramming.Lab2.Prototype;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU;

public class IntelCPU : Cpu, IPrototype<IntelCPU>
{
    private int _coreFrequency;
    private int _cores;
    private SocketTypes? _socket;
    private bool _integratedGraphics;
    private int _supportedMemory;
    private int _tdp;
    private int _powerConsumption;
    private string? _name;

    public IntelCPU(
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

    public override string? Name => _name;
    public override int CoreFrequency => _coreFrequency;
    public override int Cores => _cores;
    public override SocketTypes? Socket => _socket;
    public override bool IntegratedGraphics => _integratedGraphics;
    public override int SupportedMemory => _supportedMemory;
    public override int TDP => _tdp;
    public override int PowerConsumption => _powerConsumption;
    public override bool AvailableMotherboardForCpu(MotherBoard motherBoard)
    {
        return motherBoard.Socket != null && motherBoard.Socket.EqualsOfSockets(_socket);
    }

    public override bool EnoughTdpCoolingSystem(CoolingSystems coolingSystems)
    {
        return coolingSystems.CoolingTDP > _tdp;
    }

    public IntelCPU Clone()
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

    public IntelCPU CloneWithNewName(string? name)
    {
        IntelCPU cloneCpu = Clone();
        _name = name;

        return cloneCpu;
    }

    public IntelCPU CloneWithNewCoreFrequency(int frequency)
    {
        IntelCPU cloneCpu = Clone();
        _coreFrequency = frequency;

        return cloneCpu;
    }

    public IntelCPU CloneWithNewCores(int cores)
    {
        IntelCPU cloneCpu = Clone();
        _cores = cores;

        return cloneCpu;
    }

    public IntelCPU CloneWithNewSocket(IntelSocketType? socketType)
    {
        IntelCPU cloneCpu = Clone();
        _socket = socketType;

        return cloneCpu;
    }

    public IntelCPU CloneWithNewGpu(bool gpu)
    {
        IntelCPU cloneCpu = Clone();
        _integratedGraphics = gpu;

        return cloneCpu;
    }

    public IntelCPU CloneWithNewSupportedMemory(int supportedMemory)
    {
        IntelCPU cloneCpu = Clone();
        _supportedMemory = supportedMemory;

        return cloneCpu;
    }

    public IntelCPU CloneWithNewTdp(int tdp)
    {
        IntelCPU cloneCpu = Clone();
        _tdp = tdp;

        return cloneCpu;
    }

    public IntelCPU CloneWithNewPower(int power)
    {
        IntelCPU cloneCpu = Clone();
        _powerConsumption = power;

        return cloneCpu;
    }
}