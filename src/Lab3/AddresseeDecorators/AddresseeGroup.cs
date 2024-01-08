using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class AddresseeGroup : IAddressee
{
    private readonly IList<IAddressee> _groupOfAddressee = new List<IAddressee>();

    public AddresseeGroup(IList<IAddressee> groupOfAddressee)
    {
        _groupOfAddressee = groupOfAddressee;
    }

    public void ReceiveMessage(IMessage message)
    {
        foreach (IAddressee addressee in _groupOfAddressee)
        {
            addressee.ReceiveMessage(message);
        }
    }
}