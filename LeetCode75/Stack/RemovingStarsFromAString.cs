using System.Text;

namespace LeetCode75.Stack;

public class RemovingStarsFromAString
{
    //beats 100%
    public static string RemoveStars(string s)
    {
        const char star = '*';
        var chars = new char[s.Length];
        var pos = 0;
        foreach (var c in s)
            if (c == star) pos--;
            else chars[pos++] = c;
        return new string(chars, 0, pos);
    } 
    //beats 66.84%
    public static string RemoveStarsFirstTry(string s)
    {
        var charArray = s.ToCharArray();
        var stack = new Stack<int>();
        for (int i = 0; i < charArray.Length; ++i)
        {
            var currentCharacter = charArray[i];
            if (currentCharacter == '*')
            {
                charArray[i] = '-';
                if (stack.Count>0)
                {
                    charArray[stack.Pop()] = '-';
                }
            }
            else
            {
                stack.Push(i);
            }
        }

        var sb = new StringBuilder(charArray.Length);
        for (int i = 0; i < charArray.Length; ++i)
        {
            var currentCharacter = charArray[i];
            if (currentCharacter == '-')
                continue;
            sb.Append(currentCharacter);
        }

        return sb.ToString();
    }
}