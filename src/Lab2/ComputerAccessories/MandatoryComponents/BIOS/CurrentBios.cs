using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.BIOS;

public class CurrentBios : Bios
{
    private readonly int _biosType;
    private readonly int _biosVersion;

    public CurrentBios(int biosType, int biosVersion)
    {
        _biosType = biosType;
        _biosVersion = biosVersion;
    }

    //Сделать лист для доступных процессоров
    public override bool AvailableCPU(CPU cpu)
    {
        if 
    }

    public override int BiosType => _biosType;
    public override int BiosVersion => _biosVersion;
}