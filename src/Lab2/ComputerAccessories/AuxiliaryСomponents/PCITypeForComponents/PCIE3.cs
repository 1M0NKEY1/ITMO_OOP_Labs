namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards.PCIVersionDir;

public class PCIE3 : PCIVersions
{
    public override bool EqualsForPciVersions(PCIVersions? other) => other is PCIE3;
}