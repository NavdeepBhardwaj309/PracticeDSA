namespace myprogressapp1.Algorithms.Anagram;

public static class GroupAnagram
{
    public static List<List<string>> GroupWords(string[] words)
    {
        List<List<string>> anagramList = new();
        Dictionary<string, List<string>> dict = new();

        foreach (var word in words)
        {
            int[] count = new int[26];

            foreach (char c in word)
            {
                if (char.IsLetter(c))
                {
                    char lower = char.ToLowerInvariant(c);
                    count[lower - 'a']++;
                }
            }

            string key = string.Join('|', count);
            if (!dict.ContainsKey(key))
            {
                dict[key] = new List<string>();
            }

            dict[key].Add(word);
        }

        foreach (var key in dict.Keys)
        {
            anagramList.Add(dict[key]);
        }

        return anagramList;
    }
}