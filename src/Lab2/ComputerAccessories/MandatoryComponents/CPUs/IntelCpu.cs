using Itmo.ObjectOrientedProgramming.Lab2.Computer.CoolingSystem;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.SocketType;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.SocketTypeDir;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.Motherboards;
using Itmo.ObjectOrientedProgramming.Lab2.Prototype;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU;

public class IntelCpu : CpuBase, IPrototype<IntelCpu>
{
    private int _coreFrequency;
    private int _cores;
    private SocketTypes? _socket;
    private bool _integratedGraphics;
    private int _supportedMemory;
    private int _tdp;
    private int _powerConsumption;
    private string? _name;

    public IntelCpu(
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
    public override bool AvailableMotherboardForCpu(MotherBoardBase motherBoardBase)
    {
        return motherBoardBase.Socket != null && motherBoardBase.Socket.EqualsOfSockets(_socket);
    }

    public override bool EnoughTdpCoolingSystem(CoolingSystemsBase coolingSystemsBase)
    {
        return coolingSystemsBase.CoolingTDP > _tdp;
    }

    public IntelCpu Clone()
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

    public IntelCpu CloneWithNewName(string? name)
    {
        IntelCpu cloneCpu = Clone();
        _name = name;

        return cloneCpu;
    }

    public IntelCpu CloneWithNewCoreFrequency(int frequency)
    {
        IntelCpu cloneCpu = Clone();
        _coreFrequency = frequency;

        return cloneCpu;
    }

    public IntelCpu CloneWithNewCores(int cores)
    {
        IntelCpu cloneCpu = Clone();
        _cores = cores;

        return cloneCpu;
    }

    public IntelCpu CloneWithNewSocket(IntelSocketType? socketType)
    {
        IntelCpu cloneCpu = Clone();
        _socket = socketType;

        return cloneCpu;
    }

    public IntelCpu CloneWithNewGpu(bool gpu)
    {
        IntelCpu cloneCpu = Clone();
        _integratedGraphics = gpu;

        return cloneCpu;
    }

    public IntelCpu CloneWithNewSupportedMemory(int supportedMemory)
    {
        IntelCpu cloneCpu = Clone();
        _supportedMemory = supportedMemory;

        return cloneCpu;
    }

    public IntelCpu CloneWithNewTdp(int tdp)
    {
        IntelCpu cloneCpu = Clone();
        _tdp = tdp;

        return cloneCpu;
    }

    public IntelCpu CloneWithNewPower(int power)
    {
        IntelCpu cloneCpu = Clone();
        _powerConsumption = power;

        return cloneCpu;
    }
}