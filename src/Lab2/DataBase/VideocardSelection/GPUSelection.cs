using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards.Factory;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards.PCIVersionDir;

namespace Itmo.ObjectOrientedProgramming.Lab2.DataBase.VideocardSelection;

public class GPUSelection
{
    private const string NameGigabyte = "GIGABYTE GeForce RTX 4060 Ti EAGLE";
    private const int LebgthGigabyte = 272;
    private const int WidthGigabyte = 115;
    private const int FrequencyGigabyte = 2535;
    private const int PowerGigabyte = 500;

    private const string NameNvideo = "NVIDIA GeForce GTX 1650";
    private const int LebgthNvideo = 174;
    private const int WidthNvideo = 126;
    private const int FrequencyNvideo = 1410;
    private const int PowerNvideo = 300;

    private List<VideoCardFactory> gpu = new();

    public GPUSelection()
    {
        gpu.Add(new CurrentVideoCardFactory(
            NameGigabyte,
            LebgthGigabyte,
            WidthGigabyte,
            new PCIE4(),
            FrequencyGigabyte,
            PowerGigabyte));

        gpu.Add(new CurrentVideoCardFactory(
            NameNvideo,
            LebgthNvideo,
            WidthNvideo,
            new PCIE3(),
            FrequencyNvideo,
            PowerNvideo));
    }
}