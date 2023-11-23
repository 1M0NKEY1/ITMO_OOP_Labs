namespace Itmo.ObjectOrientedProgramming.Lab3.Addresse;

public class Messenger : IMessenger
{
    private readonly IShowText _showText;
    private IMessage? _message;

    public Messenger(IShowText showText)
    {
        _showText = showText;
    }

    public void WriteText()
    {
        _showText.DrawText(_showText.Render(_message));
    }

    public void RenderReceivedMessage(IMessage message)
    {
        _message = message;
    }
}