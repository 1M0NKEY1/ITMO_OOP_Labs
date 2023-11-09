using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Addressee;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addresse;

public class Group
{
    private readonly IList<AddresseeBase> _groupOfAddressee = new List<AddresseeBase>();

    public void AddAddresseeInGroup(AddresseeBase addresseeBase)
    {
        _groupOfAddressee.Add(addresseeBase);
    }
}