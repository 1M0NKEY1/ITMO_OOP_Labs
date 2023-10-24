using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.Factory;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.SocketType;

namespace Itmo.ObjectOrientedProgramming.Lab2.DataBase.CPUSelection;

public class IntelSelection
{
    private const string NameIntelNine = "Intel Core i9-10900x";
    private const int CoreFrequencyIntelNine = 3700;
    private const int CoreIntelNine = 10;
    private const bool IntegratedGraphicsIntelNine = false;
    private const int SupportedMemoryIntelNine = 2933;
    private const int TdpIntelNine = 165;
    private const int PowerIntelNine = 100;

    private const string NameIntelSeven = "Inte Core i7-13700KF";
    private const int CoreFrequencyIntelSeven = 3400;
    private const int CoreIntelSeven = 16;
    private const bool IntegratedGraphicsIntelSeven = false;
    private const int SupportedMemoryIntelSeven = 5600;
    private const int TdpIntelSeven = 253;
    private const int PowerIntelSeven = 100;

    private const string NameIntelFive = "Intel Core i5-6500";
    private const int CoreFrequencyIntelFive = 3200;
    private const int CoreIntelFive = 4;
    private const bool IntegratedGraphicsIntelFive = true;
    private const int SupportedMemoryIntelFive = 2133;
    private const int TdpIntelFive = 40;
    private const int PowerIntelFive = 100;

    private List<IntelCPUFactory> intelCpu = new();

    public IntelSelection()
    {
        intelCpu.Add(new IntelCPUFactory(
            NameIntelNine,
            CoreFrequencyIntelNine,
            CoreIntelNine,
            new LGATwoZeroSixSix(),
            IntegratedGraphicsIntelNine,
            SupportedMemoryIntelNine,
            TdpIntelNine,
            PowerIntelNine));

        intelCpu.Add(new IntelCPUFactory(
            NameIntelSeven,
            CoreFrequencyIntelSeven,
            CoreIntelSeven,
            new LGAOneOneFiveOne(),
            IntegratedGraphicsIntelSeven,
            SupportedMemoryIntelSeven,
            TdpIntelSeven,
            PowerIntelSeven));

        intelCpu.Add(new IntelCPUFactory(
            NameIntelFive,
            CoreFrequencyIntelFive,
            CoreIntelFive,
            new LGAOneOneFiveOne(),
            IntegratedGraphicsIntelFive,
            SupportedMemoryIntelFive,
            TdpIntelFive,
            PowerIntelFive));
    }
}