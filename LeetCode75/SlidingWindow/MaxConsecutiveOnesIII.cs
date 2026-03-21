namespace LeetCode75.SlidingWindow;

public class MaxConsecutiveOnesIII
{
    //todo: not quite sure i fully understood 
    public static int LongestOnes(int[] nums, int k)
    {
        int left = 0;
        int zeroCount = 0;
        int max = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            if (nums[right] == 0)
                zeroCount++;

            while (zeroCount > k)
            {
                if (nums[left] == 0)
                    zeroCount--;

                left++;
            }

            max = Math.Max(max, right - left + 1);
        }

        return max;
    }
}