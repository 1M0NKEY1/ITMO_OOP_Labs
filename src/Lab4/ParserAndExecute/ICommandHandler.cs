using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Requests;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public interface ICommandHandler
{
    void SetNextHandler(ICommandHandler handler);
    void Handle(IList<Request> parts);
}