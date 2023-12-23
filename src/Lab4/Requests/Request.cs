using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab4.Requests;

public class Request
{
    public Request(string input)
    {
        Input = input;
    }

    private string Input { get; }

    public IList<string> SplitString()
    {
        const char delimiter = ' ';
        return Input.Split(delimiter);
    }
}