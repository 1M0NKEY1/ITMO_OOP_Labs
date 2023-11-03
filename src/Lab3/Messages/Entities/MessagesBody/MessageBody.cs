namespace Itmo.ObjectOrientedProgramming.Lab3.MessagesBody;

public class MessageBody : IMessageBody
{
    public MessageBody(string? bodyText)
    {
        BodyText = bodyText;
    }

    private string? BodyText { get; }

    public string? GetBodyText()
    {
        return BodyText;
    }
}