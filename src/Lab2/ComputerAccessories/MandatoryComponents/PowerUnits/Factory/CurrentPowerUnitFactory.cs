namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.PowerUnit.Factory;

public class CurrentPowerUnitFactory : PowerUnitFactory
{
    private readonly string _name;
    private readonly int _highPowerLimits;

    public CurrentPowerUnitFactory(string name, int highPowerLimits)
    {
        _name = name;
        _highPowerLimits = highPowerLimits;
    }

    public override PowerUnit CreatePowerUnits()
    {
        return new CurrentPowerUnit(_name, _highPowerLimits);
    }
}