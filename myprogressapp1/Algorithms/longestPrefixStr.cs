string[] strings = { "flower", "flow", "flight" };


//T-o(N*M) where N is number of strings and M is length of the smallest string
//S-o(M) where M is length of the smallest string   
string FindLongestCommonPrefix(string[] strs)
{
    if (strs == null || strs.Length == 0)
        return "";

     int prefixLength = strings[0].Length;
    
    for (int i = 1; i < strs[0].Length; i++)
    {
       char current=strs[0][i];
       for(int j = 1; j < strs.Length; j++)
        {
            if (i >= strs[j].Length || strs[j][i] != current)
            {
                prefixLength=i;
                break;
            }
        }
    }

             char [] prefixArray = new char[prefixLength];
                for(int k=0;k<prefixLength;k++)
                {
                    prefixArray[k]=strs[0][k];
                }
  return new string(prefixArray);
}
string longestCommonPrefix = FindLongestCommonPrefix(strings);
