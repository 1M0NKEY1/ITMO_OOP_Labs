using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addresse;

public class User : IUser
{
    private readonly IList<IMessage> _listOfUnreadMessages = new List<IMessage>();

    public void SaveMessage(IMessage message)
    {
        _listOfUnreadMessages.Add(message);
    }

    public void ChangeStatus(IMessage message)
    {
        if (_listOfUnreadMessages.Contains(message))
        {
            _listOfUnreadMessages.Remove(message);
        }
    }
}