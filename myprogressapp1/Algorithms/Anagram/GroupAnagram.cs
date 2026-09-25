string[] arr=["eat", "tea", "tan", "ate", "nat", "bat","cab"];
//T-o(N^2)
//S-o(N)
//using frquency technique
List<List<string>> GroupAnagram(string[] arr)
{
      List<List<string>> anagramList=new List<List<string>>();
      Dictionary<string,List<string>> dict=new Dictionary<string, List<string>>();
      foreach(var word in arr)
      {
        int[] count=new int[26];  //number of alphabets
        //ASCII VALUE OF LOWERCASE STARTS FROM 97
        foreach(char c in word)
        {
            count[c-'a']++;  //ASCII OF Char c - a if char c='a' then 'a'-'a'=97-97=0
        }
        string key= string.Join('|',count); //creating key usng count array e.g for cab it will be[1,1,1,0,0,0.....]then key 1110000.....
        if (!dict.ContainsKey(key))
        {
            dict[key]=new List<string>();
        }
        dict[key].Add(word);
       
      }
     foreach(var key in dict.Keys)
    {
        anagramList.Add(dict[key]);
    }
   return anagramList; 
}