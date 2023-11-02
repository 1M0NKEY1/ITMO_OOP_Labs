using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.ChipSetDir;

public class AmdChip : Chip, IEquatable<Chip>
{
    public bool Equals(Chip? other) => other is AmdChip;
}