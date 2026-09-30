namespace myprogressapp1.Algorithms.prefixSufix;

public class ProductOfArray
{
    public int[] CalculateProduct(int[] arr)
    {
        if (arr == null || arr.Length == 0)
            return Array.Empty<int>();

        int[] result = new int[arr.Length];
        result[0] = 1;

        for (int i = 1; i < arr.Length; i++)
        {
            result[i] = result[i - 1] * arr[i - 1];
        }

        int suffix = 1;
        for (int i = arr.Length - 1; i > 0; i--)
        {
            result[i] = result[i] * suffix;
            suffix *= arr[i];
        }

        return result;
    }
}