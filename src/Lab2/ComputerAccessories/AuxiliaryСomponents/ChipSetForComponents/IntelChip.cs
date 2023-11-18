using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.ChipSetDir;

public class IntelChip : Chip, IEquatable<Chip>
{
    public bool Equals(Chip? other) => other is IntelChip;
}