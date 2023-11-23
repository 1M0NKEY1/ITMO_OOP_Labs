using System.Drawing;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addresse;

public interface IDisplay : IRenderReceivedMessage
{
    string RenderMessage();
    void RenderText();
    void RenderTextWithColor(Color color);
}