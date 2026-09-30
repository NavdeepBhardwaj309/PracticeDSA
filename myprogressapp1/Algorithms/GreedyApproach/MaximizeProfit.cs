namespace myprogressapp1.Algorithms.GreedyApproach;

public class MaximizeProfit
{
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