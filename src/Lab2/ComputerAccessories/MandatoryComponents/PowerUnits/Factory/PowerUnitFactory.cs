namespace Itmo.ObjectOrientedProgramming.Lab2.Computer.PowerUnit.Factory;

public class PowerUnitFactory : PowerUnitFactoryBase
{
    private string? _name;
    private int _highPowerLimits;

    public void NewInstance(string? name, int highPowerLimits)
    {
        _name = name;
        _highPowerLimits = highPowerLimits;
    }

    public override PowerUnitBase Create()
    {
        return new PowerUnit(_name, _highPowerLimits);
    }
}