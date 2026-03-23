namespace LeetCode75.HashMapSet;

public class DifferenceOfTwoArrays
{
    public static IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        var set1 = new HashSet<int>(nums1);
        var set2 = new HashSet<int>(nums2);

        var res1 = new List<int>();
        var res2 = new List<int>();

        foreach (var num in set1)
        {
            if (!set2.Contains(num))
                res1.Add(num);
        }

        foreach (var num in set2)
        {
            if (!set1.Contains(num))
                res2.Add(num);
        }

        return new List<IList<int>> { res1, res2 };
    }
}