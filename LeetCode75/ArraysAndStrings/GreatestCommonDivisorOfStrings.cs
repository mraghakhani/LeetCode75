using System.Runtime.CompilerServices;
using System.Text;

namespace LeetCode75.ArraysAndStrings;

public class GreatestCommonDivisorOfStrings
{
    public static string GcdOfStrings(string str1, string str2)
    {
        if (str1[0] != str2[0])
            return string.Empty;
        if (str1[^1] != str2[^1])
            return string.Empty;

        var shorter = str1.Length > str2.Length ? str2 : str1;
        var longer = str1.Length > str2.Length ? str1 : str2;

        if (longer.Length % shorter.Length == 0)
        {
            var count = longer.Length / shorter.Length;
            var fastResult = new StringBuilder(longer.Length);
            for (int i = 0; i < count; i++)
                fastResult.Append(shorter);

            return fastResult.ToString() == longer ? shorter : string.Empty;
        }

        var maxDevisor = 1;
        for (int i = 1; i <= shorter.Length; i++)
        {
            if (shorter.Length % i == 0 && longer.Length % i == 0)
                maxDevisor = Math.Max(maxDevisor, i);
        }

        var result = shorter[..maxDevisor];
        var minCount = shorter.Length / maxDevisor;
        var shorterBuilt = new StringBuilder();
        for (int i = 0; i < minCount; i++)
            shorterBuilt.Append(result);
        if (shorter != shorterBuilt.ToString())
            return string.Empty;
        var maxCount = longer.Length / maxDevisor;
        var longerBuilt = new StringBuilder();
        for (int i = 0; i < maxCount; i++)
            longerBuilt.Append(result);

        if (longer != longerBuilt.ToString())
            return string.Empty;

        return result;
    }

    public static string GcdOfStringsSecondTry(string str1, string str2)
    {
        if (str1 + str2 != str2 + str1)
            return string.Empty;

        var shorter = str1.Length > str2.Length ? str2 : str1;
        var longer = str1.Length > str2.Length ? str1 : str2;

        var maxDevisor = 1;
        for (int i = 1; i <= shorter.Length; i++)
        {
            if (shorter.Length % i == 0 && longer.Length % i == 0)
                maxDevisor = Math.Max(maxDevisor, i);
        }

        return shorter[..maxDevisor];
    }

    #region LeetCode Solutions

    //function to find greatest common divisor
    public int GCD(int n1, int n2)
    {
        while (n1 != 0 && n2 != 0)
        {
            if (n1 > n2)
            {
                n1 %= n2;
            }
            else
            {
                n2 %= n1;
            }
        }

        return n1 | n2;
    }

    public string GcdOfStringsMathematically(string str1, string str2) {
        if (str1 + str2 != str2 + str1)
        {
            return "";
        }

        int gcdLen = GCD(str1.Length, str2.Length);
        return str1.Substring(0, gcdLen);
    }
    
    
    
    
    

    #endregion
}