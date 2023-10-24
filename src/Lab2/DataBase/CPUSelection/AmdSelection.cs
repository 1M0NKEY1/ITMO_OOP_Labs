using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.Factory;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.SocketType.OnlyAmd;

namespace Itmo.ObjectOrientedProgramming.Lab2.DataBase.CPUSelection;

public class AmdSelection
{
    private const string NameRyzenth = "Ryzen Threadripper PRO 3955WX BOX";
    private const int CoreFrequencyRyzenth = 3700;
    private const int CoreRyzenth = 16;
    private const bool IntegratedGraphicsRyzenth = false;
    private const int SupportedMemoryRyzenth = 3200;
    private const int TdpRyzenth = 280;
    private const int PowerRyzenth = 200;

    private const string NameRyzenNine = "Ryzen 9 7900 OEM";
    private const int CoreFrequencyRyzenNine = 3700;
    private const int CoreRyzenNine = 12;
    private const bool IntegratedGraphicsRyzenNine = true;
    private const int SupportedMemoryRyzenNine = 5200;
    private const int TdpRyzenNine = 65;
    private const int PowerRyzenNine = 100;

    private const string NameRyzenSeven = "Ryzen 7 7700 OEM";
    private const int CoreFrequencyRyzenSeven = 3800;
    private const int CoreRyzenSeven = 6;
    private const bool IntegratedGraphicsRyzenSeven = true;
    private const int SupportedMemoryRyzenSeven = 5200;
    private const int TdpRyzenSeven = 65;
    private const int PowerRyzenSeven = 100;

    private const string NameRyzenFive = "Ryzen 5 7600 OEM";
    private const int CoreFrequencyRyzenFive = 3800;
    private const int CoreRyzenFive = 6;
    private const bool IntegratedGraphicsRyzenFive = true;
    private const int SupportedMemoryRyzenFive = 5200;
    private const int TdpRyzenFive = 65;
    private const int PowerRyzenFive = 100;

    private List<AmdCPUFactory> amdCpu = new();

    public AmdSelection()
    {
        amdCpu.Add(new AmdCPUFactory(
            NameRyzenth,
            CoreFrequencyRyzenth,
            CoreRyzenth,
            new WRXEight(),
            IntegratedGraphicsRyzenth,
            SupportedMemoryRyzenth,
            TdpRyzenth,
            PowerRyzenth));

        amdCpu.Add(new AmdCPUFactory(
            NameRyzenNine,
            CoreFrequencyRyzenNine,
            CoreRyzenNine,
            new AMFive(),
            IntegratedGraphicsRyzenNine,
            SupportedMemoryRyzenNine,
            TdpRyzenNine,
            PowerRyzenNine));

        amdCpu.Add(new AmdCPUFactory(
            NameRyzenSeven,
            CoreFrequencyRyzenSeven,
            CoreRyzenSeven,
            new AMFive(),
            IntegratedGraphicsRyzenSeven,
            SupportedMemoryRyzenSeven,
            TdpRyzenSeven,
            PowerRyzenSeven));

        amdCpu.Add(new AmdCPUFactory(
            NameRyzenFive,
            CoreFrequencyRyzenFive,
            CoreRyzenFive,
            new AMFive(),
            IntegratedGraphicsRyzenFive,
            SupportedMemoryRyzenFive,
            TdpRyzenFive,
            PowerRyzenFive));
    }
}