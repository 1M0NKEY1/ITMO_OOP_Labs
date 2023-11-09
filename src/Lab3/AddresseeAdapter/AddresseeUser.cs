using Itmo.ObjectOrientedProgramming.Lab3.Addresse;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class AddresseeUser : AddresseeBase
{
    private readonly User _user = new();

    public override void ReceiveMessage(IMessage message)
    {
        _user.SaveMessage(message);
    }

    public void ChangedMessageStatus(IMessage message)
    {
        _user.ChangeStatus(message);
    }

    public bool FindMessageStatus(IMessage message)
    {
        return _user.ListOfUnreadMessages.Contains(message);
    }
}