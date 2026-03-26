namespace LeetCode75.HashMapSet;

public class EqualRowAndColumnPairs
{
    // o(n^2) beats 98% 
    public static int EqualPairs(int[][] grid)
    {
        var n = grid.Length;
        var map = new Dictionary<long, int>();

        const long BASE = 131;

        // 1. hash کردن row ها
        for (var i = 0; i < n; i++)
        {
            long hash = 0;

            for (var j = 0; j < n; j++)
            {
                hash = hash * BASE + grid[i][j];
            }

            if (!map.TryAdd(hash, 1))
                map[hash]++;
        }

        var counter = 0;

        for (var col = 0; col < n; col++)
        {
            long hash = 0;

            for (var row = 0; row < n; row++)
            {
                hash = hash * BASE + grid[row][col];
            }

            if (map.TryGetValue(hash, out var count))
            {
                counter += count;
            }
        }

        return counter;
    }    
    // o(n^2) beats 83% 
    public static int EqualPairsSecondTry(int[][] grid)
    {
        var n = grid.Length;
        var map = new Dictionary<string, int>();

        foreach (var row in grid)
        {
            var key = string.Join(",", row);

            if (!map.TryAdd(key, 1))
                map[key]++;
        }

        var counter = 0;

        for (var col = 0; col < n; col++)
        {
            var columnArray = new int[n];

            for (var row = 0; row < n; row++)
            {
                columnArray[row] = grid[row][col];
            }

            var key = string.Join(",", columnArray);

            if (map.TryGetValue(key, out var value))
            {
                counter += value;
            }
        }

        return counter;
    }

    // o(n^3) beats 59%
    public static int EqualPairsFirstTry(int[][] grid)
    {
        var counter = 0;
        var n = grid.Length;

        var rowIndex = 0;
        while (rowIndex < n)
        {
            var columnIndex = 0;

            var currentRowArray = grid[rowIndex];

            while (columnIndex < n)
            {
                var j = 0;
                var isEqual = true;

                while (j < n)
                {
                    if (currentRowArray[j] != grid[j][columnIndex])
                    {
                        isEqual = false;
                        break;
                    }

                    j++;
                }

                if (isEqual)
                    counter++;

                columnIndex++;
            }

            rowIndex++;
        }

        return counter;
    }
}