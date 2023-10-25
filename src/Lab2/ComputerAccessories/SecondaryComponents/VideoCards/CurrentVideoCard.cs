using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards.PCIVersionDir;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards;

public class CurrentVideoCard : VideoCard
{
    private readonly string _name;
    private readonly int _videoCardLength;
    private readonly int _videoCardWidth;
    private readonly PCIVersions _pciVersion;
    private readonly int _chipFrequency;
    private readonly int _videoCardPower;

    public CurrentVideoCard(
        string name,
        int videoCardLength,
        int videoCardWidth,
        PCIVersions pciVersion,
        int chipFrequency,
        int videoCardPower)
    {
        _name = name;
        _videoCardLength = videoCardLength;
        _videoCardWidth = videoCardWidth;
        _pciVersion = pciVersion;
        _chipFrequency = chipFrequency;
        _videoCardPower = videoCardPower;
    }

    public override string Name => _name;
    public override int VideoCardLength => _videoCardLength;
    public override int VideoCardWidth => _videoCardWidth;
    public override PCIVersions PCIVersion => _pciVersion;
    public override int ChipFrequency => _chipFrequency;
    public override int VideoCardPower => _videoCardPower;
}