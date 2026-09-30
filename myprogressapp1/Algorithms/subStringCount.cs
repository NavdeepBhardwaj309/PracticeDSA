using myprogressapp1.Interfaces;

namespace myprogressapp1.Algorithms;

public class SubstringCount : IProgramInterface
{
    public void ExecuteProgram()
    {
        string input = "abc abc a d bc";
        int length = 2;
        var result = GetSubstringFrequency(input, length);
        foreach (var item in result)
        {
            Console.WriteLine($"Substring: {item.Key}, Count: {item.Value}");
        }
    }

    public Dictionary<string, int> GetSubstringFrequency(string input, int length)
    {
        Dictionary<string, int> dict = new();

        if (string.IsNullOrEmpty(input) || length <= 0 || length > input.Length)
            return dict;

        for (int i = 0; i <= input.Length - length; i++)
        {
            if (input[i] == ' ' || i + 1 < input.Length && input[i + 1] == ' ')
            {
                continue;
            }

            string substring = input.Substring(i, length);
            if (dict.ContainsKey(substring))
            {
                dict[substring]++;
            }
            else
            {
                dict[substring] = 1;
            }
        }

        return dict;
    }
}
