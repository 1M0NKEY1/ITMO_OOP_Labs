using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Addressee;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addresse;

public class Group
{
    private readonly IList<IAddressee> _groupOfAddressee = new List<IAddressee>();

    public void AddAddresseeInGroup(IAddressee addressee)
    {
        _groupOfAddressee.Add(addressee);
    }
}