using System.Drawing;
using Itmo.ObjectOrientedProgramming.Lab3.DisplaysDriver;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addresse;

public class Display : IDisplay
{
    private readonly IDisplayDriver _driver;
    private IMessage? _message;
    public Display(IDisplayDriver driver)
    {
        _driver = driver;
    }

    public void RenderReceivedMessage(IMessage message)
    {
        _message = message;
    }

    public string RenderMessage()
    {
        return string.Concat(_message?.Heading, _message?.Body);
    }

    public void RenderText()
    {
        _driver.OutputMessage(RenderMessage());
    }

    public void RenderTextWithColor(Color color)
    {
        _driver.OutputMessage(_driver.NewTextColor(color, RenderMessage()));
    }
}