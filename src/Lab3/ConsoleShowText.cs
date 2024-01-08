using System;
using System.Text;

namespace Itmo.ObjectOrientedProgramming.Lab3;

public class ConsoleShowText : IShowText
{
    public string Render(IMessage? message)
    {
        return new StringBuilder().Append(message?.Heading).Append(message?.Body).ToString();
    }

    public void DrawText(string text)
    {
        Console.WriteLine(text);
    }

    public void ClearOutput()
    {
        Console.Clear();
    }
}