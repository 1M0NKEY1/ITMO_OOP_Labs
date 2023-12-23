namespace Itmo.ObjectOrientedProgramming.Lab5.Tests.Moqs;

public class MoqUser
{
    public MoqUser(string name, long pin)
    {
        UserName = name;
        Pin = pin;
        Balance = 0;
    }

    public string? UserName { get; set; }
    public long Pin { get; set; }
    public decimal Balance { get; set; }
}