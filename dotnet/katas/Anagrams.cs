using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

/// <summary>
/// https://www.codewars.com/kata/523a86aa4230ebb5420001e1/train/csharp
/// </summary>
public static partial class Kata
{
    public static List<string> Anagrams(string word, List<string> words)
    {
        var resultList = new List<string>();

        var wordChars = word.ToCharArray();
        Array.Sort(wordChars);

        foreach (var current in words)
        {
            var currentChars = current.ToCharArray();
            Array.Sort(currentChars);

            var areTheSame = wordChars.SequenceEqual(currentChars);

            if (areTheSame)
                resultList.Add(current);
        }

        return resultList;
    }
}

[TestFixture]
public class AnagramsTests
{
    [Test]
    public void SampleTest()
    {
        Assert.AreEqual(new List<string> {"a"}, Kata.Anagrams("a", new List<string> {"a", "b", "c", "d"}));
    }

    [Test]
    public void SampleTest2()
    {
        Assert.AreEqual(new List<string> {"carer", "arcre", "carre"},
            Kata.Anagrams("racer", new List<string> {"carer", "arcre", "carre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr"}));
    }
}