using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards.PCIVersionDir;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards.Factory;

public class CurrentVideoCardFactory : VideoCardFactory
{
    private readonly string _name;
    private readonly int _videoCardLength;
    private readonly int _videoCardWidth;
    private readonly PCIVersions _pciVersion;
    private readonly int _chipFrequency;
    private readonly int _videoCardPower;

    public CurrentVideoCardFactory(
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

    public override VideoCard CreateVideoCard()
    {
        return new CurrentVideoCard(
            _name,
            _videoCardLength,
            _videoCardWidth,
            _pciVersion,
            _chipFrequency,
            _videoCardPower);
    }
}