using myprogressapp1.Interfaces;

namespace myprogressapp1.Algorithms.Anagram;

public class CheckAnagram : IProgramInterface
{
    public void ExecuteProgram(){
      string str1 = "listen";
      string str2 = "silent";   
      bool isAnagram = IsAnagram(str1, str2);
      Console.WriteLine($"Are '{str1}' and '{str2}' anagrams? {isAnagram}");
    }
    public  bool IsAnagram(string str1, string str2)
    {
        if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
            return str1 == str2;

        if (str1.Length != str2.Length)
            return false;

        Dictionary<char, int> dict = new();
        for (int i = 0; i < str1.Length; i++)
        {
            dict[str1[i]] = dict.TryGetValue(str1[i], out int count) ? count + 1 : 1;
        }

        for (int i = 0; i < str2.Length; i++)
        {
            if (!dict.TryGetValue(str2[i], out int count))
                return false;

            count--;
            if (count < 0)
                return false;

            dict[str2[i]] = count;
        }

        return true;
    }
}