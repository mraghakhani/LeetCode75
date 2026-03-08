using System.Text;

namespace LeetCode75.ArraysAndStrings;

public class MergeStringsAlternately
{
    public static string MergeAlternately(string word1, string word2)
    {
        var sb = new StringBuilder();
        var length = Math.Max(word1.Length, word2.Length);
        for (int i = 0; i < length; i++)
        {
            if (i < word1.Length)
            {
                sb.Append(word1[i]);
            }

            if (i < word2.Length)
            {
                sb.Append(word2[i]);
            }
        }

        return sb.ToString();
    }

    public static string MergeAlternatelyMostRatedInLeetCode(string word1, string word2)
    {
        StringBuilder res = new StringBuilder();
        int i = 0, j = 0;
        while (i < word1.Length && j < word2.Length)
        {
            res.Append(word1[i]).Append(word2[j]);
            i++;
            j++;
        }

        while (i < word1.Length)
        {
            res.Append(word1[i]);
            i++;
        }

        while (j < word2.Length)
        {
            res.Append(word2[j]);
            j++;
        }

        return res.ToString();
    }
}