using System.Linq;
using NUnit.Framework;

/// <summary>
/// https://www.codewars.com/kata/52761ee4cffbc69732000738/train/csharp
/// </summary>
public static partial class Kata
{
    public static string GoodVsEvil(string good, string evil)
    {
        var goodCounts = good.Split(' ').Select(int.Parse).ToArray();
        var goodResult = goodCounts[0] * 1 + goodCounts[1] * 2 + goodCounts[2] * 3 + goodCounts[3] * 3 + goodCounts[4] * 4 + goodCounts[5] * 10;

        var evilCounts = evil.Split(' ').Select(int.Parse).ToArray();
        var evilResult = evilCounts[0] * 1 + evilCounts[1] * 2 + evilCounts[2] * 2 + evilCounts[3] * 2 + evilCounts[4] * 3 + evilCounts[5] * 5 + evilCounts[6] * 10;

        if (goodResult == evilResult)
            return "Battle Result: No victor on this battle field";

        return goodResult > evilResult ? "Battle Result: Good triumphs over Evil" : "Battle Result: Evil eradicates all trace of Good";
    }
}

[TestFixture]
public class GoodVsEvilTests
{
    [Test]
    public static void EvilShouldWin()
    {
        Assert.AreEqual("Battle Result: Evil eradicates all trace of Good", Kata.GoodVsEvil("1 1 1 1 1 1", "1 1 1 1 1 1 1"));
    }

    [Test]
    public static void GoodShouldTriumph()
    {
        Assert.AreEqual("Battle Result: Good triumphs over Evil", Kata.GoodVsEvil("0 0 0 0 0 10", "0 1 1 1 1 0 0"));
    }

    [Test]
    public static void ShouldBeATie()
    {
        Assert.AreEqual("Battle Result: No victor on this battle field", Kata.GoodVsEvil("1 0 0 0 0 0", "1 0 0 0 0 0 0"));
    }
}