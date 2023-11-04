namespace Itmo.ObjectOrientedProgramming.Lab3.Addresse;

public class Messenger : IMessenger
{
    private readonly IShowText _showText;

    public Messenger(IShowText showText)
    {
        _showText = showText;
    }

    public void WriteText(IMessage message)
    {
        _showText.DrawText(_showText.Render(message));
    }
}