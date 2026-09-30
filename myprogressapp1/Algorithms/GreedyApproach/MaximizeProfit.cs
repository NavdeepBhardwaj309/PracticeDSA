using myprogressapp1.Interfaces;

namespace myprogressapp1.Algorithms.GreedyApproach;

public class MaximizeProfit : IProgramInterface
{
    public void ExecuteProgram()
    {
        int[] arr = { 7, 1, 5, 3, 6, 4 };
        int result = GetMaxProfit(arr);
        Console.WriteLine($"Max profit is {result}");
    }

    public int GetMaxProfit(int[] arr)
    {
        if (arr == null || arr.Length == 0)
            throw new ArgumentException("Array cannot be null or empty.", nameof(arr));

        int minPrice = int.MaxValue;
        int maxProfit = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            minPrice = Math.Min(minPrice, arr[i]);
            int profit = arr[i] - minPrice;
            maxProfit = Math.Max(maxProfit, profit);
        }

        return maxProfit;
    }
}