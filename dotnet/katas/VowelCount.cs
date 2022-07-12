using System.Linq;
using NUnit.Framework;

/// <summary>
/// https://www.codewars.com/kata/54ff3102c1bad923760001f3
/// </summary>
public static class VowelCount
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;

        var vowels = new char[] {'a', 'e', 'i', 'o', 'u'};

        foreach (var c in str)
        {
            if (vowels.Contains(c))
                vowelCount++;
        }

        return vowelCount;
    }
}

[TestFixture]
public class VowelCountTests
{
    [Test]
    public void TestCase1()
    {
        Assert.AreEqual(5, VowelCount.GetVowelCount("abracadabra"), "Nope!");
    }
}