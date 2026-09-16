string str="A man, a plan, a canal Panama";

//T-O(N) S-O(1)
bool IsPalindrome(string str);
{
    int left=0;
    int right=str.Length-1;
    
    while (left < right)
    {   //remove space
        while(left<right && char.IsLetterOrDigit(str[left]))
           left++;
        while(left<right && char.IsLetterOrDigit(str[right]))
           right--;

        if(str[left]!=str[right])
           return false;
        left++;
        right--;

    }
    return true;
}

bool result= IsPalindrome(str);
Console.WriteLine("strings  is Palindrome. - {0}", result);
