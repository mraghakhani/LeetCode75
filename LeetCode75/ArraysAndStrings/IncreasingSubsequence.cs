namespace LeetCode75.ArraysAndStrings;

public class IncreasingSubsequence
{
    public static bool IncreasingTriplet(int[] nums)
    {
        if (nums.Length < 3)
            return false;

        var min = nums[0];
        var second = int.MaxValue;

        for (int i = 1; i < nums.Length; i++)
        {
            var current = nums[i];
            if (min >= current)
                min = current;
            else if (current <= second)
                second = current;
            else
                return true;
        }

        return false;
    }

    public static bool IncreasingN(int[] nums, int n)
    {
        if (nums.Length < n)
            return false;
        var result = new int[n];
        for (int i = 0; i < n; i++)
        {
            result[i] = int.MaxValue;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            var current = nums[i];
            for (int j = 0; j < n; j++)
            {
                if (result[j] >= current)
                {
                    result[j] = current;
                    if (j == n - 1)
                        return true;
                    break;
                }
            }
        }
        
        return false;
    }
}