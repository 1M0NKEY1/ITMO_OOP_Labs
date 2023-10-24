namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.PowerUnit;

public class CurrentPowerUnit : PowerUnit
{
    private readonly string _name;
    private readonly int _highPowerLimits;

    public CurrentPowerUnit(string name, int highPowerLimits)
    {
        _name = name;
        _highPowerLimits = highPowerLimits;
    }

    public override string Name => _name;
    public override int HighPowerLimits => _highPowerLimits;
}