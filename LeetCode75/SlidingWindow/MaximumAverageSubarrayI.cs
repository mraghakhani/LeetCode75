namespace LeetCode75.SlidingWindow;

public class MaximumAverageSubarrayI
{
    public static double FindMaxAverage(int[] nums, int k)
    {
        var maxSum = -double.MaxValue;
        double lastSum = 0;

        for (int start = 0, end = k - 1; end < nums.Length; start++, end++)
        {
            double sum = 0;
            if (start == 0)
                for (int i = start; i <= end; i++)
                    sum += nums[i];
            else
            {
                sum = lastSum - nums[start - 1] + nums[end];
            }
            lastSum = sum;
            maxSum = Math.Max(maxSum, sum);
        }

        return maxSum / k;
    }

    //this timed out on a really long input in leetcode
    public static double FindMaxAverageFirstTry(int[] nums, int k)
    {
        double maxSum = -double.MaxValue;

        for (int start = 0, end = k - 1; end < nums.Length; start++, end++)
        {
            double sum = 0;
            for (int i = start; i <= end; i++)
                sum += nums[i];
            maxSum = Math.Max(maxSum, sum);
        }

        return maxSum / k;
    }
}