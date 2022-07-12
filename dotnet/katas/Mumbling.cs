using System.Text;
using NUnit.Framework;

/// <summary>
/// https://www.codewars.com/kata/5667e8f4e3f572a8f2000039
/// </summary>
public class Accumul
{
    public static string Accum(string s)
    {
        var sb = new StringBuilder();
        for (var i = 0; i < s.Length; i++)
        {
            var letter = s[i];
            sb.Append(char.ToUpperInvariant(letter));
            sb.Append(new string(char.ToLowerInvariant(letter), i));
            sb.Append("-");
        }

        return sb.ToString().TrimEnd('-');
    }
}

[TestFixture]
public class UnitTest1
{
    [Test]
    public void TestMethod1()
    {
        testing(Accumul.Accum("ZpglnRxqenU"), "Z-Pp-Ggg-Llll-Nnnnn-Rrrrrr-Xxxxxxx-Qqqqqqqq-Eeeeeeeee-Nnnnnnnnnn-Uuuuuuuuuuu");
        testing(Accumul.Accum("NyffsGeyylB"), "N-Yy-Fff-Ffff-Sssss-Gggggg-Eeeeeee-Yyyyyyyy-Yyyyyyyyy-Llllllllll-Bbbbbbbbbbb");
        testing(Accumul.Accum("MjtkuBovqrU"), "M-Jj-Ttt-Kkkk-Uuuuu-Bbbbbb-Ooooooo-Vvvvvvvv-Qqqqqqqqq-Rrrrrrrrrr-Uuuuuuuuuuu");
        testing(Accumul.Accum("EvidjUnokmM"), "E-Vv-Iii-Dddd-Jjjjj-Uuuuuu-Nnnnnnn-Oooooooo-Kkkkkkkkk-Mmmmmmmmmm-Mmmmmmmmmmm");
        testing(Accumul.Accum("HbideVbxncC"), "H-Bb-Iii-Dddd-Eeeee-Vvvvvv-Bbbbbbb-Xxxxxxxx-Nnnnnnnnn-Cccccccccc-Ccccccccccc");
    }

    private static void testing(string actual, string expected)
    {
        Assert.AreEqual(expected, actual);
    }
}