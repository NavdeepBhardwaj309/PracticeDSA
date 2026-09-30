namespace myprogressapp1.Algorithms;

public class LongestPrefixStr
{
    public string FindLongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
            return string.Empty;

        int prefixLength = strs[0].Length;

        for (int i = 1; i < strs[0].Length; i++)
        {
            char current = strs[0][i];
            for (int j = 1; j < strs.Length; j++)
            {
                if (i >= strs[j].Length || strs[j][i] != current)
                {
                    prefixLength = i;
                    break;
                }
            }

            if (prefixLength == i)
                break;
        }

        char[] prefixArray = new char[prefixLength];
        for (int k = 0; k < prefixLength; k++)
        {
            prefixArray[k] = strs[0][k];
        }

        return new string(prefixArray);
    }
}
