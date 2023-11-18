using Itmo.ObjectOrientedProgramming.Lab2.Computer.ComputerCase;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.CoolingSystem;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.PowerUnit;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.RAM;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.Motherboards;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.SSDs;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapters;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.Builder;

public interface IBuilder
{
    Computer? Create();
    IBuilder WithComputerCase(ComputerCasesBase computerCasesBase);
    IBuilder WithCoolingSystem(CoolingSystemsBase coolingSystemsBase);
    IBuilder WithCpu(CpuBase cpuBase);
    IBuilder WithMotherboard(MotherBoardBase motherBoardBase);
    IBuilder WithPowerUnit(PowerUnitBase powerUnitBase);
    IBuilder WithRam(RamBase ramBase);
    IBuilder WithSsd(SSDBase ssdBase);
    IBuilder WithVideoCard(VideoCardBase videoCardBase);
    IBuilder WithWifiAdapter(WifiAdapterBase wifiAdapterBase);
}