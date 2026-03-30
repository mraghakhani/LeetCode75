using System.Text;

namespace LeetCode75.Stack;

public class StringDecode
{
    private const char Open = '[';
    private const char Close = ']';
    private const char Zero = '0';
    // beats 100%
    public static string DecodeString(string s)
    {
        var i = 0;
        return Decode(s, ref i);
    }
    private static string Decode(string s, ref int i)
    {
        var result = new StringBuilder();
        var repeat = 0;

        while (i < s.Length)
        {
            var c = s[i];

            if (char.IsDigit(c))
            {
                repeat = repeat * 10 + (c - Zero);
            }
            else if (c == Open)
            {
                i++;

                var inner = Decode(s, ref i);

                for (var j = 0; j < repeat; j++)
                    result.Append(inner);

                repeat = 0;
            }
            else if (c == Close)
            {
                return result.ToString();
            }
            else
            {
                result.Append(c);
            }

            i++;
        }

        return result.ToString();
    }
    // beats 87
    public static string DecodeStringFirstTry(string s)
    {

        var countStack = new Stack<int>();
        var stringStack = new Stack<StringBuilder>();
        var current = new StringBuilder(s.Length);
        var repeatCount = 0;
        for (var i = 0; i < s.Length; i++)
        {
            var currentCharacter = s[i];
            if (char.IsDigit(currentCharacter))
            {
                repeatCount = repeatCount * 10 + currentCharacter - Zero;
                continue;
            }

            if (currentCharacter == Open)
            {
                countStack.Push(repeatCount);
                stringStack.Push(current);

                current = new StringBuilder();
                repeatCount = 0;
                continue;
            }

            if (currentCharacter == Close)
            {
                var count = countStack.Pop();
                var prev = stringStack.Pop();
                for (var j = 0; j < count; j++)
                    prev.Append(current);
                current = prev;

                continue;
            }

            current.Append(currentCharacter);
        }

        return current.ToString();
    }
}