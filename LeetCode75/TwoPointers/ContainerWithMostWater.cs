namespace LeetCode75.TwoPointers;

public static class ContainerWithMostWater
{
    public static int MaxArea(int[] height)
    {
        var result = 0;
        int i = 0;
        int j = height.Length - 1;
        while (i < j)
        {
            var left = height[i];
            var right = height[j];
            result = Math.Max(Math.Min(left, right) * (j - i), result);
            if (left < right)
            {
                i++;
                continue;
            }

            j--;
        }
        return result;
    }
}