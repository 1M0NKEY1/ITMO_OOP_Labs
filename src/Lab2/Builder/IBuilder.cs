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
    IBuilder WithComputerCase(ComputerCases computerCases);
    IBuilder WithCoolingSystem(CoolingSystems coolingSystems);
    IBuilder WithCpu(Cpu cpu);
    IBuilder WithMotherboard(MotherBoard motherBoard);
    IBuilder WithPowerUnit(PowerUnit powerUnit);
    IBuilder WithRam(Ram ram);
    IBuilder WithSsd(SSD ssd);
    IBuilder WithVideoCard(VideoCard videoCard);
    IBuilder WithWifiAdapter(WifiAdapter wifiAdapter);
}