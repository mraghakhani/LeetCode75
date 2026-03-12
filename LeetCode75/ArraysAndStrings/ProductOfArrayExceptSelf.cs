namespace LeetCode75.ArraysAndStrings;

public class ProductOfArrayExceptSelf
{
    public static int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        var result = new int[n];

        result[0] = 1;
        for (int i = 1; i < n; i++)
        {
            result[i] = result[i - 1] * nums[i - 1];
        }
        int suffix = 1;

        for (int i = n - 1; i >= 0; i--)
        {
            result[i] *= suffix;
            suffix *= nums[i];
        }
        return result;
    }
    // Timed out for a really long input
    public static int[] FirstTryProductExceptSelf(int[] nums) {
        var result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = 1;
            for (int j = i; j < nums.Length; j++)
            {
                if (i== j)
                    continue;
                result[i] *= nums[j];
            }
        }
        return result;
    }
}