using myprogressapp1.Interfaces;
namespace myprogressapp1.Algorithms.Anagram;

public  class GroupAnagram: IProgramInterface
{
    public void ExecuteProgram(){
        string[] words = { "eat", "tea", "tan", "ate", "nat", "bat" };
        List<List<string>> groupedAnagrams = GroupWords(words);

        Console.WriteLine("Grouped Anagrams:");
        foreach (var group in groupedAnagrams)
        {
            Console.WriteLine(string.Join(", ", group));
        }

    }  
    public  List<List<string>> GroupWords(string[] words)
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