using Itmo.ObjectOrientedProgramming.Lab2.Computer.CoolingSystem;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.SocketType.OnlyAmd;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.SocketTypeDir;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.Motherboards;
using Itmo.ObjectOrientedProgramming.Lab2.Prototype;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU;

public class AmdCpu : CpuBase, IPrototype<AmdCpu>
{
    private int _coreFrequency;
    private int _cores;
    private SocketTypes? _socket;
    private bool _integratedGraphics;
    private int _supportedMemory;
    private int _tdp;
    private int _powerConsumption;
    private string? _name;

    public AmdCpu(
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

    public AmdCpu Clone()
    {
        return new AmdCpu(
            _name,
            _coreFrequency,
            _cores,
            _socket,
            _integratedGraphics,
            _supportedMemory,
            _tdp,
            _powerConsumption);
    }

    public AmdCpu CloneWithNewName(string? name)
    {
        AmdCpu cloneCpu = Clone();
        _name = name;

        return cloneCpu;
    }

    public AmdCpu CloneWithNewCoreFrequency(int frequency)
    {
        AmdCpu cloneCpu = Clone();
        _coreFrequency = frequency;

        return cloneCpu;
    }

    public AmdCpu CloneWithNewCores(int cores)
    {
        AmdCpu cloneCpu = Clone();
        _cores = cores;

        return cloneCpu;
    }

    public AmdCpu CloneWithNewSocket(AmdSocketType? socketType)
    {
        AmdCpu cloneCpu = Clone();
        _socket = socketType;

        return cloneCpu;
    }

    public AmdCpu CloneWithNewGpu(bool gpu)
    {
        AmdCpu cloneCpu = Clone();
        _integratedGraphics = gpu;

        return cloneCpu;
    }

    public AmdCpu CloneWithNewSupportedMemory(int supportedMemory)
    {
        AmdCpu cloneCpu = Clone();
        _supportedMemory = supportedMemory;

        return cloneCpu;
    }

    public AmdCpu CloneWithNewTdp(int tdp)
    {
        AmdCpu cloneCpu = Clone();
        _tdp = tdp;

        return cloneCpu;
    }

    public AmdCpu CloneWithNewPower(int power)
    {
        AmdCpu cloneCpu = Clone();
        _powerConsumption = power;

        return cloneCpu;
    }
}