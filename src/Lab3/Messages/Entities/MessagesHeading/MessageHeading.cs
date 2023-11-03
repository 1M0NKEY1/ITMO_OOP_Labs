namespace Itmo.ObjectOrientedProgramming.Lab3.MessagesHeadings;

public class MessageHeading : IMessageHeading
{
    public MessageHeading(string text)
    {
        HeadingText = text;
    }

    private string HeadingText { get; }

    public string GetHeadingText()
    {
        return HeadingText;
    }
}