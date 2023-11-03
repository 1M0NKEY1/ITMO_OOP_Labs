using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class AddresseeGroup
{
    private readonly IList<AddresseeBase> _groupOfAddressee = new List<AddresseeBase>();

    public void AddAddresseeInGroup(AddresseeBase addresseeBase)
    {
        _groupOfAddressee.Add(addresseeBase);
    }
}