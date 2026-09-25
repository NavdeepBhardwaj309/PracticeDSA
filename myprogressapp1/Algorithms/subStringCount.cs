//find the count of consecutive substrings of length k

//string str="hello";
string str="abc abc a d bc";
int k=2;

Dictionary<string, int> getSubstringFrequency(string str,int k)
{
    Dictionary<string,int>dict=new Dictionary<string,int>();
    for(int i = 0; i <= str.Length - k; i++)
    {
        if(str[i]==' '|| str[i + 1] == ' ')
        {
            continue;
        }
      string substring = str.Substring(i, k);
      if(dict.ContainsKey(substring))
      {
        dict[substring]++;
      }
      else
      {
        dict[substring]=1;
      }
    }
    return dict;
}

var result =getSubstringFrequency(str,k);
foreach(var item in result)
{
    Console.WriteLine("Substring: {0}, Count: {1}", item.Key, item.Value);
}
