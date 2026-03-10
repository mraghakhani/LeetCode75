
namespace LeetCode75.ArraysAndStrings;

public class ReverseVowelsOfAString
{
    private static HashSet<char> _vowels = new() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
    public string LeetCodeSolution(string s) {
        char[] word = s.ToCharArray();
        int start = 0;
        int end = s.Length - 1;
        string vowels = "aeiouAEIOU";

        while (start < end) {
            while (start < end && !vowels.Contains(word[start].ToString())) {
                start++;
            }
            while (start < end && !vowels.Contains(word[end].ToString())) {
                end--;
            }

            char temp = word[start];
            word[start] = word[end];
            word[end] = temp;

            start++;
            end--;
        }

        return new string(word);
    }
    public static string FirstTryReverseVowels(string s)
    {
        var directVowels = new Queue<int>();
        var reverseVowels = new Queue<int>();
        var stringArray = s.ToCharArray();
        var j = stringArray.Length - 1;
        for (int i = 0; i < stringArray.Length && j >= 0 && i < j && j > i; i++, j--)
        {
            var left = stringArray[i];
            var right = stringArray[j];
            if (_vowels.Contains(left))
            {
                if (reverseVowels.Count > 0)
                {
                    var index = reverseVowels.Dequeue();
                    var valueOfIndex = stringArray[index];
                    stringArray[index] = left;
                    stringArray[i] = valueOfIndex;
                }
                else
                {
                    directVowels.Enqueue(i);
                }
            }

            if (_vowels.Contains(right))
            {
                if (directVowels.Count > 0)
                {
                    var index = directVowels.Dequeue();
                    var valueOfIndex = stringArray[index];
                    stringArray[index] = right;
                    stringArray[j] = valueOfIndex;
                }
                else
                {
                    reverseVowels.Enqueue(j);
                }
            }
        }

        return string.Join("", stringArray);
    }


    public static string ReverseVowels(string s)
    {
        var vowels = new List<int>();
        var stringArray = s.ToCharArray();
        for (int i = 0; i < stringArray.Length; i++)
        {
            var left = stringArray[i];
            if (_vowels.Contains(left))
                vowels.Add(i);
        }

        int j = vowels.Count - 1;
        for (int i = 0; i < vowels.Count && i < j && j > i; i++, j--)
        {
            var right = stringArray[vowels[i]];
            var left = stringArray[vowels[j]];
            stringArray[vowels[i]] = left;
            stringArray[vowels[j]] = right;
        }

        return string.Join("", stringArray);
    }
}