namespace LeetCode75.HashMapSet;

public class DetermineIfTwoStringsAreClose
{
    // beats 95
    public static bool CloseStrings(string word1, string word2)
    {
        if (word1.Length != word2.Length)
            return false;
        
        var freq1 = new int[26];
        var freq2 = new int[26];

        foreach (var c in word1)
            freq1[c - 'a']++;

        foreach (var c in word2)
        {
            var index = c - 'a';
            freq2[index]++;
            if (freq1[index] == 0)
                return false;
        }
        
        Array.Sort(freq1);
        Array.Sort(freq2);

        for (int i = 25; i >= 0; i--)
        {
            if (freq1[i] != freq2[i])
                return false;
        }

        return true;
    } 
    // beats 89%
    public static bool CloseStringsFourth(string word1, string word2)
    {
        if (word1.Length != word2.Length)
            return false;
        
        var freq1 = new int[26];
        var freq2 = new int[26];

        foreach (var c in word1)
            freq1[c - 'a']++;

        foreach (var c in word2)
        {
            var index = c - 'a';
            freq2[index]++;
            if (freq1[index] == 0)
                return false;
        }
        
        Array.Sort(freq1);
        Array.Sort(freq2);

        for (int i = 0; i < 26; i++)
        {
            if (freq1[i] != freq2[i])
                return false;
        }

        return true;
    } 
    // beats 78%
    public static bool CloseStringsThirdTry(string word1, string word2)
    {
        if (word1.Length != word2.Length)
            return false;
        
        var freq1 = new int[26];
        var freq2 = new int[26];

        foreach (var c in word1)
            freq1[c - 'a']++;

        foreach (var c in word2)
            freq2[c - 'a']++;

        for (int i = 0; i < 26; i++)
        {
            if ((freq1[i] == 0) != (freq2[i] == 0))
                return false;
        }
        Array.Sort(freq1);
        Array.Sort(freq2);

        for (int i = 0; i < 26; i++)
        {
            if (freq1[i] != freq2[i])
                return false;
        }

        return true;
    } 
    // beats 48%
    public static bool CloseStringsSecondTry(string word1, string word2)
    {
        if (word1.Length != word2.Length)
            return false;
        
        var dict1 = new Dictionary<char, int>();
        var dict2 = new Dictionary<char, int>();

        foreach (var c in word1)
            if (!dict1.TryAdd(c, 1))
                dict1[c]++;
        foreach (var c in word2)
        {
            if (!dict1.ContainsKey(c))
                return false;
            if (!dict2.TryAdd(c, 1))
                dict2[c]++;
        }

        if (dict1.Count != dict2.Count)
            return false;
        
        var dictValues1= new Dictionary<int,int>();
        var dictValues2= new Dictionary<int,int>();
        
        foreach (var value in dict1.Values)
            if (!dictValues1.TryAdd(value, 1))
                dictValues1[value]++;
        
        foreach (var value in dict2.Values)
            if (!dictValues2.TryAdd(value, 1))
                dictValues2[value]++;
        
        if (dictValues1.Count != dictValues2.Count)
            return false;
        foreach (var (key,value) in dictValues1)
        {
            if (!dictValues2.TryGetValue(key, out var value1))
                return false;
            if (value1 != value)
                return false;
        }
        
        return true;
    }
    // beats 5%
    public static bool CloseStringsFirstTry(string word1, string word2)
    {
        if (word1.Length != word2.Length)
            return false;
        var word1Hash = new HashSet<char>(word1);
        var word2Hash = new HashSet<char>(word2);
        if (word1Hash.Count != word2Hash.Count)
            return false;

        foreach (var wordHash in word1Hash)
            if (!word2Hash.Contains(wordHash))
                return false;
        
        var dict1 = new Dictionary<char, int>();
        var dict2 = new Dictionary<char, int>();

        foreach (var c in word1)
            if (!dict1.TryAdd(c, 1))
                dict1[c]++;
        foreach (var c in word2)
            if (!dict2.TryAdd(c, 1))
                dict2[c]++;
        var dictValues1= new Dictionary<int,int>();
        var dictValues2= new Dictionary<int,int>();
        
        foreach (var value in dict1.Values)
            if (!dictValues1.TryAdd(value, 1))
                dictValues1[value]++;
        
        foreach (var value in dict2.Values)
            if (!dictValues2.TryAdd(value, 1))
                dictValues2[value]++;
        
        if (dictValues1.Count != dictValues2.Count)
            return false;
        foreach (var (key,value) in dictValues1)
        {
            if (!dictValues2.TryGetValue(key, out var value1))
                return false;
            if (value1 != value)
                return false;
        }
        
        return true;
    }
}