 
 string str="silent";
  // T-O(N/2) S-O(1)
 string reverseString(string str){

    int i=0;
   int j=str.Length-1;
   while(i<j){

       char temp=str[j];
       str[j]=str[i];
      str[i]=temp;
      i++;
      j--;

    }
   return str;
}


var result= reverseString(str);
Console.WriteLine("reversed string. - {0}", result);
