using System;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.CoolingSystem;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.SocketTypeDir;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.Motherboards;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU;

public abstract class Cpu : IComponent, IEquatable<IComponent>
{
    public abstract string Name { get; }
    public abstract int CoreFrequency { get; }
    public abstract int Cores { get; }
    public abstract SocketTypes Socket { get; }
    public abstract bool IntegratedGraphics { get; }
    public abstract int SupportedMemory { get; }
    public abstract int TDP { get; }
    public abstract int PowerConsumption { get; }
    public abstract bool AvailableMotherboardForCpu(MotherBoard motherBoard);
    public abstract bool EnoughTdpCoolingSystem(CoolingSystems coolingSystems);
    public bool Equals(IComponent? other)
    {
        if (other is Cpu otherCpu)
        {
            return Socket.Equals(otherCpu.Socket);
        }

        return false;
    }

    public override int GetHashCode()
    {
        return Socket.GetHashCode();
    }
}