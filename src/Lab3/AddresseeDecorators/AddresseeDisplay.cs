using Itmo.ObjectOrientedProgramming.Lab3.Addresse;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class AddresseeDisplay : IAddressee
{
    private readonly IDisplay _display;

    public AddresseeDisplay(IDisplay display)
    {
        _display = display;
    }

    public void ReceiveMessage(IMessage message)
    {
        _display.RenderReceivedMessage(message);
    }
}