using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards.PCIVersionDir;
using Itmo.ObjectOrientedProgramming.Lab2.Prototype;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards;

public class CurrentVideoCard : VideoCard, IPrototype<CurrentVideoCard>
{
    private int _videoCardLength;
    private int _videoCardWidth;
    private PCIVersions _pciVersion;
    private int _chipFrequency;
    private int _videoCardPower;
    private string _name;

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
    public CurrentVideoCard Clone()
    {
        return new CurrentVideoCard(
            _name,
            _videoCardLength,
            _videoCardWidth,
            _pciVersion,
            _chipFrequency,
            _videoCardPower);
    }

    public CurrentVideoCard SetName(string name)
    {
        CurrentVideoCard cloneVideoCard = Clone();
        _name = name;

        return cloneVideoCard;
    }

    public CurrentVideoCard SetLength(int length)
    {
        CurrentVideoCard cloneVideoCard = Clone();
        _videoCardLength = length;

        return cloneVideoCard;
    }

    public CurrentVideoCard SetWidth(int width)
    {
        CurrentVideoCard cloneVideoCard = Clone();
        _videoCardWidth = width;

        return cloneVideoCard;
    }

    public CurrentVideoCard SetPCI(PCIVersions pciVersions)
    {
        CurrentVideoCard cloneVideoCard = Clone();
        _pciVersion = pciVersions;

        return cloneVideoCard;
    }

    public CurrentVideoCard SetChipFrequency(int frequency)
    {
        CurrentVideoCard cloneVideoCard = Clone();
        _chipFrequency = frequency;

        return cloneVideoCard;
    }

    public CurrentVideoCard SetPower(int power)
    {
        CurrentVideoCard cloneVideoCard = Clone();
        _videoCardPower = power;

        return cloneVideoCard;
    }
}