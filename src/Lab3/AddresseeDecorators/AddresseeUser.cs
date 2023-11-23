using Itmo.ObjectOrientedProgramming.Lab3.Addresse;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class AddresseeUser : IAddressee
{
    private readonly IUser _user;

    public AddresseeUser(IUser user)
    {
        _user = user;
    }

    public void ReceiveMessage(IMessage message)
    {
        _user.SaveMessage(message);
    }
}