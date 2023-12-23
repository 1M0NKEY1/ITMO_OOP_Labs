using System;
using System.Runtime.Serialization;

namespace Itmo.ObjectOrientedProgramming.Lab1;

public class CustomExceptions : ArgumentException
{
    public CustomExceptions()
    {
    }

    public CustomExceptions(string message)
        : base(message)
    {
    }

    public CustomExceptions(string message, string paramName)
        : base(message, paramName)
    {
    }

    public CustomExceptions(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public CustomExceptions(string message, string paramName, Exception innerException)
        : base(message, paramName, innerException)
    {
    }

    protected CustomExceptions(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}