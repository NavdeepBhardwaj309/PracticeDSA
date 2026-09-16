int arr={2,3,-2,4}; //{-2,3,-4}


//T-O(N) S-O(1)
int MaxProductSaubArrary(int[] arr)
{
    int maxProduct=arr[0];
    int minProduct=arr[0];
    int result=arr[0];

    for(int i = 1; i < arr.Length; i++)
    {   
        int a=maxProduct*arr[i];
        int b= minProduct*arr[i];
        maxProduct=Math.Max(arr[i],Math.Max(a,b));  //3 //24
        minProduct=Math.Min(arr[i],Math.Min(a,b));//-6
       result=Math.Max(result, maxProduct);
    }
   return result;
}


int  result= MaxProductSaubArrary(arr);
Console.WriteLine("max Product is {0}", result);