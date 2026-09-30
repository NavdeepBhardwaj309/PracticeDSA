namespace myprogressapp1.Algorithms.DynamicTracking;

public class MaxProductSubArray
{
    public int FindMaxProduct(int[] arr)
    {
        if (arr == null || arr.Length == 0)
            throw new ArgumentException("Array cannot be null or empty.", nameof(arr));

        int maxProduct = arr[0];
        int minProduct = arr[0];
        int result = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            int a = maxProduct * arr[i];
            int b = minProduct * arr[i];
            maxProduct = Math.Max(arr[i], Math.Max(a, b));
            minProduct = Math.Min(arr[i], Math.Min(a, b));
            result = Math.Max(result, maxProduct);
        }

        return result;
    }
}