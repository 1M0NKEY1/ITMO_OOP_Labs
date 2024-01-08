using System.Drawing;

namespace Itmo.ObjectOrientedProgramming.Lab3.DisplaysDriver;

public interface IDisplayDriver
{
    void ClearOutput();
    void OutputMessage(string message);
    void AddText(string? addText);
    string NewTextColor(Color color, string message);
}