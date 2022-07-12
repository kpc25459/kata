using System.Linq;
using NUnit.Framework;

/// <summary>
/// https://www.codewars.com/kata/53db96041f1a7d32dc0004d2/train/csharp
/// </summary>
public static partial class Kata
{
    public static string DoneOrNot(int[][] board)
    {
        if (!board.All(CheckRow))
            return "Try again!";

        for (var c = 0; c < 9; c++)
        {
            var column = new int[9];

            for (var r = 0; r < 9; r++)
                column[r] = board[r][c];

            if (!CheckRow(column))
                return "Try again!";
        }
        
        //TODO: check region

        return "Finished!";
    }

    private static bool CheckRow(int[] row)
    {
        return row.All(r => r > 0 && r < 10) && row.Distinct().Count() == 9;
    }
}

[TestFixture]
public class SudokuTests
{
    private static object[] testCases = new object[]
    {
        new object[]
        {
            "Finished!",
            new int[][]
            {
                new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
                new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
                new int[] {1, 9, 8, 3, 4, 2, 5, 6, 7},
                new int[] {8, 5, 9, 7, 6, 1, 4, 2, 3},
                new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
                new int[] {7, 1, 3, 9, 2, 4, 8, 5, 6},
                new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
                new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
                new int[] {3, 4, 5, 2, 8, 6, 1, 7, 9},
            },
        },
        new object[]
        {
            "Try again!",
            new int[][]
            {
                new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
                new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
                new int[] {1, 9, 8, 3, 0, 2, 5, 6, 7},
                new int[] {8, 5, 0, 7, 6, 1, 4, 2, 3},
                new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
                new int[] {7, 0, 3, 9, 2, 4, 8, 5, 6},
                new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
                new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
                new int[] {3, 0, 0, 2, 8, 6, 1, 7, 9},
            },
        },
        new object[]
        {
            "Try again!",
            new int[][]
            {
                new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
                new int[] {6, 3, 4, 6, 7, 8, 9, 1, 2},
                new int[] {1, 9, 8, 3, 4, 2, 5, 6, 7},
                new int[] {8, 5, 9, 7, 6, 1, 4, 2, 3},
                new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
                new int[] {7, 1, 3, 9, 2, 4, 8, 5, 6},
                new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
                new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
                new int[] {3, 4, 5, 2, 8, 6, 1, 7, 9},
            },
        },
        new object[]
        {
            "Try again!",
            new int[][]
            {
                new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9},
                new int[] {2, 3, 1, 5, 6, 4, 8, 9, 7},
                new int[] {3, 1, 2, 6, 4, 5, 9, 7, 8},
                new int[] {4, 5, 6, 7, 8, 9, 1, 2, 3},
                new int[] {5, 6, 4, 8, 9, 7, 2, 3, 1},
                new int[] {6, 4, 5, 9, 7, 8, 3, 1, 2},
                new int[] {7, 8, 9, 1, 2, 3, 4, 5, 6},
                new int[] {8, 9, 7, 2, 3, 1, 5, 6, 4},
                new int[] {9, 7, 8, 3, 1, 2, 6, 4, 5}
            },
        },
    };

    [Test, TestCaseSource("testCases")]
    public void Test(string expected, int[][] board) => Assert.AreEqual(expected, Kata.DoneOrNot(board));
}