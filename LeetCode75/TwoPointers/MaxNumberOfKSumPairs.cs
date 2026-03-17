namespace LeetCode75.TwoPointers;

public class MaxNumberOfKSumPairs
{
    public static int MaxOperations(int[] nums, int k)
    {
        var result = 0;
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var item = nums[i];
            var x = k - item;
            if (map.ContainsKey(x) && map[x] > 0)
            {
                result++;
                map[x]--;
            }
            else
            {
                if (!map.ContainsKey(item))
                    map[item] = 0;

                map[item]++;
            }
        }


        return result;
    }

    //this approach can work two if we sort the array 
    public static int MaxOperationsFirstTry(int[] nums, int k)
    {
        var i = 0;
        var j = nums.Length - 1;
        var result = 0;
        while (i < j)
        {
            var left = nums[i];
            var right = nums[j];
            var sum = left + right;
            if (sum == k)
            {
                result++;
                i++;
                j--;
                continue;
            }

            if (sum < k)
            {
                if (left < right)
                {
                    j--;
                }
                else if (left == right)
                {
                    j--;
                    i++;
                }
                else
                {
                    i++;
                }

                continue;
            }

            if (left > right)
                i++;
            else if (left == right)
            {
                i++;
                j--;
            }
            else
            {
                j--;
            }
        }

        return result;
    }
}