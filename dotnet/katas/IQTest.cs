using System.Linq;
using NUnit.Framework;

/// <summary>
/// https://www.codewars.com/kata/552c028c030765286c00007d
/// </summary>
public class IQ
{
    public static int Test(string numbers)
    {
        var numbersArray = numbers.Split(" ").Select(int.Parse).ToList();

        var firstIsOdd = numbersArray[0] % 2 != 0;

        for (var i = 1; i < numbersArray.Count; i++)
        {
            var currentIsOdd = numbersArray[i] % 2 != 0;

            if (firstIsOdd != currentIsOdd)
            {
                var nextNumber = numbersArray.ElementAtOrDefault(i + 1);
                if (nextNumber != 0)
                {
                    var nextIsOdd = nextNumber % 2 != 0;
                    return !nextIsOdd && !currentIsOdd ? i : i + 1;
                }

                return i + 1;
            }
        }

        return 0;
    }
}

[TestFixture]
public class IQTests
{
    [Test]
    public void Test0()
    {
        Assert.AreEqual(2, IQ.Test("1 2 1"));
    }

    [Test]
    public void Test1()
    {
        Assert.AreEqual(1, IQ.Test("1 2 2 2"));
    }


    [Test]
    public void Test2()
    {
        Assert.AreEqual(2, IQ.Test("2 1 2 2"));
    }

    [Test]
    public void Test3()
    {
        Assert.AreEqual(3, IQ.Test("2 2 1 2 2 2 2 2 2 2"));
    }


    [Test]
    public void Test4()
    {
        Assert.AreEqual(3, IQ.Test("2 4 7 8 10"));
    }

    [Test]
    public void Test5()
    {
        Assert.AreEqual(4, IQ.Test("2 2 2 1"));
    }
}