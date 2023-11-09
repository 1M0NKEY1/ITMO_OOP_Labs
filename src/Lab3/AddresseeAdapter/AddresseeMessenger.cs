using Itmo.ObjectOrientedProgramming.Lab3.Addresse;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class AddresseeMessenger : AddresseeBase
{
    private readonly Messenger _messenger = new(new ConsoleShowText());

    public override void ReceiveMessage(IMessage message)
    {
        _messenger.WriteText(message);
    }
}