using Itmo.ObjectOrientedProgramming.Lab3.Addressee;

namespace Itmo.ObjectOrientedProgramming.Lab3.TopicDir;

public class Topic : TopicBase
{
    private readonly string? _topicName;
    private AddresseeBase? _addressee;

    public Topic(string? name, AddresseeBase? addressee)
    {
        _topicName = name;
        _addressee = addressee;
    }

    public override void SendMessage(IMessage message)
    {
        _addressee?.ReceiveMessage(message);
    }

    public void ChangeStatus(IMessage message)
    {
        var addressee = (AddresseeUser?)_addressee;
        addressee?.ChangedMessageStatus(message);
    }

    public bool MessageStatus(IMessage message)
    {
        var addressee = (AddresseeUser?)_addressee;

        return addressee != null && addressee.FindMessageStatus(message);
    }
}