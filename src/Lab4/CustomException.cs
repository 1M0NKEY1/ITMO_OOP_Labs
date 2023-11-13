using System;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class CustomException : ArgumentException
{
    public CustomException(string message)
        : base(message)
    {
    }

    public CustomException(string message, string paramName)
        : base(message, paramName)
    {
    }

    public CustomException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public CustomException(string message, string paramName, Exception innerException)
        : base(message, paramName, innerException)
    {
    }
}