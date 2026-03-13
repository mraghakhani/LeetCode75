namespace LeetCode75.ArraysAndStrings;

public class IncreasingTripletSubsequence
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
}