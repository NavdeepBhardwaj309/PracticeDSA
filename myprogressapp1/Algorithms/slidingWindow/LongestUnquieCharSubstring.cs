string str="pwwkew"; //"abcabcbb";
//T O(N) S-O(K)
int LongestSubstring(string str)
{
    Dictionary<char, int> lastSeen = new();   //p:0,w:1,//p:0,w:2,k:3,e:4// p:0,w:5,k:3,e:4
    int left=0;   //0>2>3
    int maxLength=0;
    // int right=str.Length-1;
    for(int right = 0; right < str.Length; right++)
    {
        if (lastSeen.ContainsKey(str[right])){
            int previousIndex=lastSeen[str[right]]; //1>2
            left=Math.Max(left, previousIndex+1);
        }
       
            lastSeen[str[right]]=right;
        
        maxLength=Math.Max(maxLength, right-left+1);
    }
  return maxLength;
}

int  result= LongestSubstring(str);
Console.WriteLine("LongestSubstring length is {0}", result);