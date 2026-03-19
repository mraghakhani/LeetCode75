namespace LeetCode75.SlidingWindow;

public class MaximumNumberOfVowelsInASubstringOfGivenLength
{
    private static readonly HashSet<char> Vowels = new() { 'a', 'e', 'i', 'o', 'u' };

    public static int MaxVowels(string s, int k)
    {
        var maxCount = 0;
        var lastCount = 0;

        for (int start = 0, end = k - 1; end < s.Length; start++, end++)
        {
            var count = 0;
            if (start == 0)
                for (int i = start; i <= end; i++)
                {
                    if (Vowels.Contains(s[i]))
                    {
                        count++;
                    }
                }
            else
            {
                count = lastCount - (Vowels.Contains(s[start - 1]) ? 1 : 0) + (Vowels.Contains(s[end]) ? 1 : 0);
            }

            lastCount = count;
            maxCount = Math.Max(maxCount, count);
            if (maxCount == k)
                return maxCount;
        }

        return maxCount;
    }
}