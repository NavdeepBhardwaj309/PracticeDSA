 
 string str="silent";
  // T-O(N/2) S-O(1)
 string reverseString(string str){

    char[] chars = str.ToCharArray();

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


var result= reverseString(str);
Console.WriteLine("reversed string. - {0}", result);
