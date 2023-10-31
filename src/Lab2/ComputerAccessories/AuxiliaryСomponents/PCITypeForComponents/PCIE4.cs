namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards.PCIVersionDir;

public class PCIE4 : PCIVersions
{
    public override bool EqualsForPciVersions(PCIVersions? other) => other is PCIE4;
}