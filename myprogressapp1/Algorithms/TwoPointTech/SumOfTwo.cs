using System.Diagnostics;

public class SumOfTwo
{
    public SumOfTwo()
    {
        
    }
    public SumOfTwo(int[] sortedArray, int targetSum)
    {
        bool doesSumExist = CheckSumExist(sortedArray, targetSum);
        Console.WriteLine("doesSumExist", doesSumExist);
    }

    public bool CheckSumExist(int[] arr, int sum)
    {
        bool exists = false;
        int left = 0; int right = arr.Length - 1;
        while (left < right)
        {
            //int mid = (right - left) / 2;
            if (arr[left] + arr[right] == sum)
            {
                exists = true;
            }
            else if (arr[left] + arr[right] < sum)
            {
                left++;
            }
            else
            {
                right--;
            }

        }

        return exists;
    }
}