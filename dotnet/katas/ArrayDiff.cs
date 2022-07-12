using System.Linq;
using NUnit.Framework;

/// <summary>
/// https://www.codewars.com/kata/523f5d21c841566fde000009/train/csharp
/// </summary>
public class KataArrayDiff
{
    public static int[] ArrayDiff(int[] a, int[] b) => a.Where(current => !b.Contains(current)).ToArray();
}

[TestFixture]
public class ArrayDiffTests
{
    [Test]
    [TestCase(new[] {1, 2}, new[] {1}, ExpectedResult = new[] {2})]
    [TestCase(new[] {1, 2, 2}, new[] {1}, ExpectedResult = new[] {2, 2})]
    [TestCase(new[] {1, 2, 2}, new[] {2}, ExpectedResult = new[] {1})]
    [TestCase(new[] {1, 2, 2}, new int[0], ExpectedResult = new[] {1, 2, 2})]
    [TestCase(new int[0], new[] {1, 2}, ExpectedResult = new int[0])]
    public int[] SampleTest(int[] a, int[] b)
    {
        return KataArrayDiff.ArrayDiff(a, b);
    }
}