using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class Te : IEnumerable<object[]>
{
    public static IEnumerable<object[]> GetNumbers()
    {
        yield return new object[] { 5, 1, 3, 9 };
        yield return new object[] { 228, 239, 1488, 9 };
    }

    public static bool IsOddNumber(int number)
    {
        return number % 2 != 0;
    }

    IEnumerator<object[]> IEnumerable<object[]>.GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    public IEnumerator GetEnumerator()
    {
        return GetEnumerator();
    }

    [Theory]
    [MemberData(nameof(GetNumbers), MemberType = typeof(TMP))]
    public void AllNumbersAreOddWithMemberDataFromDataGenerator(int a, int b, int c, int d)
    {
        Assert.True(IsOddNumber(a));
        Assert.True(IsOddNumber(b));
        Assert.True(IsOddNumber(c));
        Assert.True(IsOddNumber(d));
    }
}