namespace Itmo.ObjectOrientedProgramming.Lab4.Requests;

public class Request
{
    public Request(string input)
    {
        Input = input;
    }

    public string Input { get; }
}