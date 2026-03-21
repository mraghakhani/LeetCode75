namespace LeetCode75.SlidingWindow;

public class LongestSubarrayOfOnes
{
    /// <summary>
    /// Given a binary array nums, you should delete one element from it.
    ///Return the size of the longest non-empty subarray containing only 1's in the resulting array.
    /// Return 0 if there is no such subarray.
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public static int LongestSubarray(int[] nums) {
        int left = 0;
        int zeroCount = 0;
        int max = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            if (nums[right] == 0)
                zeroCount++;

            while (zeroCount > 1)
            {
                if (nums[left] == 0)
                    zeroCount--;

                left++;
            }

            max = Math.Max(max, right - left);
        }

        return max;
    }
}