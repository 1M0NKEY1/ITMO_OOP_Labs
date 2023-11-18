using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards.PCIVersionDir;
using Itmo.ObjectOrientedProgramming.Lab2.Prototype;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards;

public class VideoCard : VideoCardBase, IPrototype<VideoCard>
{
    private int _videoCardLength;
    private int _videoCardWidth;
    private PCIVersions? _pciVersion;
    private int _chipFrequency;
    private int _videoCardPower;
    private string? _name;

    public VideoCard(
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

    public override string? Name => _name;
    public override int VideoCardLength => _videoCardLength;
    public override int VideoCardWidth => _videoCardWidth;
    public override PCIVersions? PCIVersion => _pciVersion;
    public override int ChipFrequency => _chipFrequency;
    public override int VideoCardPower => _videoCardPower;
    public VideoCard Clone()
    {
        return new VideoCard(
            _name,
            _videoCardLength,
            _videoCardWidth,
            _pciVersion,
            _chipFrequency,
            _videoCardPower);
    }

    public VideoCard CloneWithNewName(string? name)
    {
        VideoCard cloneVideoCard = Clone();
        _name = name;

        return cloneVideoCard;
    }

    public VideoCard CloneWithNewLength(int length)
    {
        VideoCard cloneVideoCard = Clone();
        _videoCardLength = length;

        return cloneVideoCard;
    }

    public VideoCard CloneWithNewWidth(int width)
    {
        VideoCard cloneVideoCard = Clone();
        _videoCardWidth = width;

        return cloneVideoCard;
    }

    public VideoCard CloneWithNewPCI(PCIVersions? pciVersions)
    {
        VideoCard cloneVideoCard = Clone();
        _pciVersion = pciVersions;

        return cloneVideoCard;
    }

    public VideoCard CloneWithNewChipFrequency(int frequency)
    {
        VideoCard cloneVideoCard = Clone();
        _chipFrequency = frequency;

        return cloneVideoCard;
    }

    public VideoCard CloneWithNewPower(int power)
    {
        VideoCard cloneVideoCard = Clone();
        _videoCardPower = power;

        return cloneVideoCard;
    }
}