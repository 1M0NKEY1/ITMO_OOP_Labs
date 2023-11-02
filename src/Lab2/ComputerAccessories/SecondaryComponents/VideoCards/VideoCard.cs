using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards.PCIVersionDir;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards;

public abstract class VideoCard : IComponent
{
    public abstract string? Name { get; }
    public abstract int VideoCardLength { get; }
    public abstract int VideoCardWidth { get; }
    public abstract PCIVersions? PCIVersion { get; }
    public abstract int ChipFrequency { get; }
    public abstract int VideoCardPower { get; }
}