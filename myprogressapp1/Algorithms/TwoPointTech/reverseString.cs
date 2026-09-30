using myprogressapp1.Interfaces;

namespace myprogressapp1.Algorithms.TwoPointTech;

public class ReverseString : IProgramInterface
{
    public void ExecuteProgram()
    {
        string input = "silent";
        string result = Reverse(input);
        Console.WriteLine($"Reversed string: {result}");
    }

    public string Reverse(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        char[] chars = input.ToCharArray();
        int i = 0;
        int j = chars.Length - 1;

        while (i < j)
        {
            char temp = chars[j];
            chars[j] = chars[i];
            chars[i] = temp;

            i++;
            j--;
        }

        return new string(chars);
    }
}
