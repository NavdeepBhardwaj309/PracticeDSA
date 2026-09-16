// Input:
// [1,2,3,4]

// Output:
// [24,12,8,6]

int[] arr={1,2,3,4};
//T-O(N) S-O(1)
int[] ProductOfArray(int[] arr)
{
    int [] result=new int[arr.Length] ;
    result[0]=1;
    for(int i=1;i<arr.Length; i++)
    {
        result[i]=result[i-1]*arr[i-1];
    } 
    //result={1,1,2,6}
    int sufffix=1;
    for(int i=arr.Length-1; i>0;i--)
    {
        result[i]=result[i]*sufffix;
        sufffix*=arr[i];

    }
return result; 

}

int[] result=ProductOfArray(arr);

foreach(var element in result)
{
    Console.WriteLine(element);
}