using myprogressapp1.Interfaces;

namespace myprogressapp1.Algorithms.KadaneAlgo;

public class MaxSumArray : IProgramInterface
{
    public void ExecuteProgram()
    {
        int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        int result = FindMaxSubArray(arr);
        Console.WriteLine($"Max sum is {result}");
    }

    public int FindMaxSubArray(int[] arr)
    {
        if (arr == null || arr.Length == 0)
            throw new ArgumentException("Array cannot be null or empty.", nameof(arr));

        int currentSum = arr[0];
        int maxSum = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            currentSum = Math.Max(arr[i], currentSum + arr[i]);
            maxSum = Math.Max(maxSum, currentSum);
        }

        return maxSum;
    }
}