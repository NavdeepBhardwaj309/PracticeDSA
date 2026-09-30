namespace myprogressapp1.Algorithms.slidingWindow;

public class LongestUnquieCharSubstring
{
    public int LongestSubstring(string input)
    {
        if (string.IsNullOrEmpty(input))
            return 0;

        Dictionary<char, int> lastSeen = new();
        int left = 0;
        int maxLength = 0;

        for (int right = 0; right < input.Length; right++)
        {
            if (lastSeen.ContainsKey(input[right]))
            {
                int previousIndex = lastSeen[input[right]];
                left = Math.Max(left, previousIndex + 1);
            }

            lastSeen[input[right]] = right;
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}