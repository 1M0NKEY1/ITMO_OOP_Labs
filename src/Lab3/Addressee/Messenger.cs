namespace Itmo.ObjectOrientedProgramming.Lab3.Addresse;

public class Messenger : IMessenger
{
    public string WriteText(IMessage message)
    {
        string? heading = message.Heading;
        string? body = message.Body;

        return "messenger" + "\n" + heading + "\n" + body;
    }
}