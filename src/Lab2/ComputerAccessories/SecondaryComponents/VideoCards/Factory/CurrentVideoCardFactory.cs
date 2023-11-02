using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards.PCIVersionDir;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards.Factory;

public class CurrentVideoCardFactory : VideoCardFactory
{
    private string? _name;
    private int _videoCardLength;
    private int _videoCardWidth;
    private PCIVersions? _pciVersion;
    private int _chipFrequency;
    private int _videoCardPower;

    public void NewInstance(
        string? name,
        int videoCardLength,
        int videoCardWidth,
        PCIVersions? pciVersion,
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

    public override VideoCard Create()
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