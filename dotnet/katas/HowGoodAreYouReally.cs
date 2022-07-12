using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/5601409514fc93442500010b
/// </summary>
public class HowGoodAreYouReally
{
    public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
    {
        return YourPoints > ClassPoints.Average();
    }
}