using Itmo.ObjectOrientedProgramming.Lab3.Addresse;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class AddresseeMessenger : IAddressee
{
    private readonly IMessenger _messenger;

    public AddresseeMessenger(IMessenger messenger)
    {
        _messenger = messenger;
    }

    public void ReceiveMessage(IMessage message)
    {
        _messenger.RenderReceivedMessage(message);
    }
}