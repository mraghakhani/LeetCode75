namespace LeetCode75.TwoPointers;

public class MoveZeroes
{
    public static void MoveArrayZeroes(int[] nums)
    {
        if (nums.Length == 1)
            return;

        for (int i = 0, j = 1; i < nums.Length && j < nums.Length;j++)
        {
            var currentI = nums[i];
            var currentJ = nums[j];
            if (currentI != 0)
            {
                i++;
                continue;
            }
            if (currentJ != 0)
            {
                nums[i] = currentJ;
                nums[j] = 0;
                i++;
            }

        }
    }
    public static void MoveArrayZeroesSecond(int[] nums)
    {
        if (nums.Length == 1)
            return;

        var zeroIndexes = new Queue<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var current = nums[i];
            if (current != 0 && zeroIndexes.Count > 0)
            {
                var zeroIndex = zeroIndexes.Dequeue();
                nums[zeroIndex] = current;
                nums[i] = 0;
                zeroIndexes.Enqueue(i);
            }
            else if (current == 0)
            {
                zeroIndexes.Enqueue(i);
            }
        }
    }

    public static void MoveArrayZeroesFirst(int[] nums)
    {
        if (nums.Length == 1)
            return;

        for (int i = 0; i < nums.Length; i++)
        {
            var current = nums[i];
            if (current != 0)
                continue;

            for (int j = i + 1; j < nums.Length; j++)
            {
                var next = nums[j];
                if (next == 0)
                    continue;

                nums[i] = next;
                nums[j] = current;
                break;
            }
        }
    }
}