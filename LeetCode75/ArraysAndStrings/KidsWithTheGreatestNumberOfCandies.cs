namespace LeetCode75.ArraysAndStrings;

public class KidsWithTheGreatestNumberOfCandies
{
    public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        int greatestNumber = 0;
        for (int i = 0; i < candies.Length; i++)
        {
            greatestNumber = Math.Max(candies[i], greatestNumber);
        }
        var result = new bool[candies.Length];
        for (int i = 0; i < candies.Length; i++)
            result[i] = greatestNumber <= candies[i] + extraCandies;
        return result;
    }
}