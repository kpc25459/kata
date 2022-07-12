using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

/// <summary>
/// https://www.codewars.com/kata/525f50e3b73515a6db000b83/train/csharp
/// </summary>
public class CreatePhoneNumberKata
{
    public static string CreatePhoneNumber(int[] numbers) => $"({string.Join("", numbers.Take(3))}) {string.Join("", numbers.Skip(3).Take(3))}-{string.Join("", numbers.Skip(6))}";
}

public class CreatePhoneNumberKata2
{
    public static string CreatePhoneNumber(int[] numbers)
    {

        //var chars = String.Join("", numbers.Select(n => n.ToString()));
        //var chars = string.Concat(numbers).ToString("(000) 000-0000");

        var chars2 = long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
        return string.Format("{0:(000) 000-0000}", chars2);
    }
}

[TestFixture]
public class CreatePhoneNumberTests
{
    [Test]
    [TestCase(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}, ExpectedResult = "(123) 456-7890")]
    //[TestCase(new int[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1}, ExpectedResult = "(111) 111-1111")]
    public static string FixedTest(int[] numbers)
    {
        return CreatePhoneNumberKata2.CreatePhoneNumber(numbers);
    }
}