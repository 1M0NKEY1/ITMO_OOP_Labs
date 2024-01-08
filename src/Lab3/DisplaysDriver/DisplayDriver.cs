using System.Drawing;

namespace Itmo.ObjectOrientedProgramming.Lab3.DisplaysDriver;

public class DisplayDriver : IDisplayDriver
{
    private readonly IShowText? _showText;
    private string _emptyString = string.Empty;

    public DisplayDriver(IShowText showText)
    {
        _showText = showText;
    }

    public void OutputMessage(string message)
    {
        _showText?.DrawText(message);
    }

    public void ClearOutput()
    {
        _showText?.ClearOutput();
    }

    public void AddText(string? addText)
    {
        _emptyString += addText;
    }

    public string NewTextColor(Color color, string message)
    {
        return Crayon.Output.Rgb(color.R, color.G, color.B).Text(message);
    }
}