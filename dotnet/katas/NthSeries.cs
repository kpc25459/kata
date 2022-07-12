using NUnit.Framework;

/// <summary>
/// https://www.codewars.com/kata/555eded1ad94b00403000071/train/csharp
/// </summary>
public class NthSeries
{
    public static string seriesSum(int n)
    {
        if (n == 0)
            return "0.00";

        var sum = 1.0d;
        var divider = 4;

        for (var i = 0; i < n - 1; i++)
        {
            sum += (double) 1 / divider;
            divider += 3;
        }

        return sum.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
    }
}

[TestFixture]
public class NthSeriesTests
{
    [Test]
    public void Test0()
    {
        Assert.AreEqual("0.00", NthSeries.seriesSum(0));
    }

    [Test]
    public void Test1()
    {
        Assert.AreEqual("1.00", NthSeries.seriesSum(1));
    }

    [Test]
    public void Test5()
    {
        Assert.AreEqual("1.57", NthSeries.seriesSum(5));
    }

    [Test]
    public void Test9()
    {
        Assert.AreEqual("1.77", NthSeries.seriesSum(9));
    }
}