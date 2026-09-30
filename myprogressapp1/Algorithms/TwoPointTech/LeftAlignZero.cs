namespace myprogressapp1.Algorithms.TwoPointTech;

public class LeftAlignZero
{
    public int[] LeftAlignZeros(int[] arr)
    {
        if (arr == null || arr.Length == 0)
            return Array.Empty<int>();

        int i = arr.Length - 1;
        int j = arr.Length - 1;

        while (i >= 0)
        {
            if (arr[i] != 0)
            {
                arr[j] = arr[i];
                j--;
            }
            i--;
        }

        while (j >= 0)
        {
            arr[j] = 0;
            j--;
        }

        return arr;
    }

    public int[] RightAlignZeros(int[] arr)
    {
        if (arr == null || arr.Length == 0)
            return Array.Empty<int>();

        int i = 0;
        int j = 0;

        while (i < arr.Length)
        {
            if (arr[i] != 0)
            {
                arr[j] = arr[i];
                j++;
            }
            i++;
        }

        while (j < arr.Length)
        {
            arr[j] = 0;
            j++;
        }

        return arr;
    }
}