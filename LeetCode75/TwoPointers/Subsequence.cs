namespace LeetCode75.TwoPointers;

public class Subsequence
{
    public static bool IsSubsequence(string s, string t)
    {
        if (s.Length > t.Length)
            return false;
        for (int i = 0, j = 0; i < s.Length && j < t.Length; j++)
        {
            var currentS = s[i];
            var currentT = t[j];
            if (currentS == currentT)
            {
                if (i != s.Length -1 && j == t.Length - 1)
                    return false;
                i++;
                continue;
            }

            if (j == t.Length - 1)
                return false;
        }

        return true;
    }
}