using System.Drawing;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addresse;

public interface IDisplay : IRenderableReceivevedMessage
{
    string RenderMessage();
    void RenderTextWithColor(Color color);
}