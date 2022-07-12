using System;
using NUnit.Framework;

public partial class Kata
{
    public static int StringToNumber(String str) => int.Parse(str);
}

[TestFixture]
public class StringToNumberTest
{
    [Test]
    public void test1()
    {
        Assert.AreEqual(1234, Kata.StringToNumber("1234"));
    }

    [Test]
    public void test2()
    {
        Assert.AreEqual(605, Kata.StringToNumber("605"));
    }

    [Test]
    public void test3()
    {
        Assert.AreEqual(1405, Kata.StringToNumber("1405"));
    }

    [Test]
    public void test4()
    {
        Assert.AreEqual(-7, Kata.StringToNumber("-7"));
    }
}