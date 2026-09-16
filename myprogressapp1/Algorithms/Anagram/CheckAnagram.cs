string str1="listen";
string str2="silent";
//check frequency of characters using dictionary
bool CheckAnagram(string str1, string str2)
{
    
    
    if(str1.Length!=str2.Length)
      return false;

    Dictionary<char,int>dict=new Dictionary<char, int>();
    for(int i = 0; i < str1.Length; i++)
    {
        if (dict.ContainsKey(str1[i]))
        {
            dict[str1[i]]++;
        }
        else
        {
            dict[str1[i]]=1;
        }
    }
    for(int i = 0; i < str2.Length; i++)
    {
        if (!dict.ContainsKey(str2[i]))
        {
           return false;
        }
        dict[str2[i]]--;

        if(dict[str2[i]]<0)
          return false;
       
    }

    return true;
}


bool  result= CheckAnagram(str1,str2);
Console.WriteLine("strings are anagram. - {0}", result);