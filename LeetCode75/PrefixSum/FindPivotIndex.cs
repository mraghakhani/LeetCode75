namespace LeetCode75.PrefixSum;

public class FindPivotIndex
{
    public static int PivotIndex(int[] nums)
    {
        var sum = 0;
        for (int i = 0; i < nums.Length; i++)
            sum += nums[i];

        var leftSum = 0;
        var rightSum = sum;
        for (int i = 0; i < nums.Length; i++)
        {
            rightSum -= nums[i];
            if (i != 0)
                leftSum += nums[i - 1];

            if (rightSum == leftSum)
                return i;
        }
        return -1;
    }

    public static int PivotIndexFirstTry(int[] nums)
    {
        var sum = 0;
        for (int i = 0; i < nums.Length; i++)
            sum += nums[i];
        var leftSum = 0;
        var rightSum = sum - nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            // if (leftSum > rightSum) return -1;
            if (rightSum == leftSum)
                return i - 1;
            rightSum -= nums[i];
            leftSum += nums[i - 1];
        }

        if (rightSum == leftSum)
            return nums.Length - 1;
        return -1;
    }
}