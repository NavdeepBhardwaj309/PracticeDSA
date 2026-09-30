using myprogressapp1.Interfaces;

namespace myprogressapp1.Algorithms.TwoPointTech;

public class Palindrome : IProgramInterface
{
    public void ExecuteProgram()
    {
        string input = "A man, a plan, a canal Panama";
        bool result = IsPalindromeString(input);
        Console.WriteLine($"Palindrome: {result}");
    }

    public bool IsPalindromeString(string input)
    {
        if (string.IsNullOrEmpty(input))
            return true;

        int left = 0;
        int right = input.Length - 1;

        while (left < right)
        {
            while (left < right && !char.IsLetterOrDigit(input[left]))
                left++;

            while (left < right && !char.IsLetterOrDigit(input[right]))
                right--;

            if (char.ToLowerInvariant(input[left]) != char.ToLowerInvariant(input[right]))
                return false;

            left++;
            right--;
        }

        return true;
    }
}
