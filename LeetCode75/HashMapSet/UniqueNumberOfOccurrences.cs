namespace LeetCode75.HashMapSet;

public class UniqueNumberOfOccurrences
{
    public static bool UniqueOccurrences(int[] arr)
    {
        var dict = new Dictionary<int, int>();

        foreach (var num in arr)
        {
            if (!dict.TryAdd(num, 1))
                dict[num]++;
        }

        var seen = new HashSet<int>();

        foreach (var count in dict.Values)
        {
            if (!seen.Add(count))
                return false;
        }

        return true;
    }
}