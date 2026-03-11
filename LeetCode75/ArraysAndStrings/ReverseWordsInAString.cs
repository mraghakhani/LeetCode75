using System.Text;

namespace LeetCode75.ArraysAndStrings;

public class ReverseWordsInAString
{
    private const char Space = ' ';

    // the sky is blue
    public static string ReverseWords(string s) {
      
        int n=s.Length;
        int i=n-1;
        StringBuilder sb= new StringBuilder();

        while(i>=0){

            //Skip spaces from the right
            while(i>=0 && s[i]==Space) i--;

            //If start of s reached and everything was spaces
            if(i<0) break;

            //Found the end of word
            int right=i;

            //Now move left to find start of the word
            while(i>=0 && s[i]!=Space) i--;

            //Extract the word
            //Start index : i+1 , End index : right
            //Length :right-i
            string word=s.Substring(i+1,right-i);

            //if sb already has words add space seperator first
            if(sb.Length>0) sb.Append(Space);
            sb.Append(word);
        }

        return sb.ToString();
        
    }

    public static string SecondTryReverseWords(string s)
    {
        var words = new Stack<string>(s.Length);
        var word = new StringBuilder(s.Length, s.Length);
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] != Space)
            {
                word.Append(s[i]);
                if (word.Length > 0 && i == s.Length - 1)
                {
                    words.Push(word.ToString());
                    word.Clear();
                }

                continue;
            }

            if (word.Length > 0)
            {
                words.Push(word.ToString());
                word.Clear();
            }
        }

        var totalWords = words.Count;

        for (int i = 0; i < totalWords; i++)
        {
            word.Append(words.Pop());
            if (i != totalWords - 1)
                word.Append(Space);
        }

        return word.ToString();
    }

    public static string FirstTryReverseWords(string s)
    {
        var words = new List<string>();
        var word = new StringBuilder();
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] != Space)
            {
                word.Append(s[i]);
                if (word.Length > 0 && i == s.Length - 1)
                {
                    words.Add(word.ToString());
                    word.Clear();
                }

                continue;
            }

            if (word.Length > 0)
            {
                words.Add(word.ToString());
                word.Clear();
            }
        }

        var result = new StringBuilder();
        for (var i = words.Count - 1; i >= 0; i--)
        {
            result.Append(words[i]);
            if (i > 0)
            {
                result.Append(Space);
            }
        }

        return result.ToString();
    }
}