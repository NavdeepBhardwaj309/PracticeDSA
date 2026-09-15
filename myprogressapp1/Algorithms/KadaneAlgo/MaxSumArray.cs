int [] arr={-2,1,-3,4,-1,2,1,-5,4};

// use Kadane algorithm when some array elements are negative
// T=O(n) S=O(1)
 int maxSubArray(int[] arr)
{
    int currentSum=arr[0];
    int maxSum=arr[0];
    for(int i=1; i < arr.Length; i++)
    {
        currentSum=Math.Max(arr[i], currentSum+arr[i]);
        maxSum=Math.Max(maxSum,currentSum);
    }

    return maxSum;
}


int  result= maxSubArray(arr);
Console.WriteLine("max sum is {0}", result);