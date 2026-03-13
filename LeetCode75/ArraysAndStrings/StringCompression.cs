namespace LeetCode75.ArraysAndStrings;

public class StringCompression
{
    public static int Compress(char[] chars)
    {
        if (chars.Length == 1)
            return 1;
        int n = chars.Length;
        int write = 0;
        int read = 0;

        while (read < n)
        {
            char currentChar = chars[read];
            int count = 0;

            // Count consecutive characters
            while (read < n && chars[read] == currentChar)
            {
                read++;
                count++;
            }

            // Write the character
            chars[write++] = currentChar;

            // Write the count if > 1
            if (count > 1)
            {
                foreach (char c in count.ToString())
                {
                    chars[write++] = c;
                }
            }
        }

        return write;
    }
}