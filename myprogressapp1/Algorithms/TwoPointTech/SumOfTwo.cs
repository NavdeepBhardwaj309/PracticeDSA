using myprogressapp1.Interfaces;
using System.Diagnostics;

public class SumOfTwo : IProgramInterface
{
    public void ExecuteProgram()
    {
        int[] sortedArray = { 1, 2, 3, 4, 6, 8 };
        int targetSum = 10;
        bool doesSumExist = CheckSumExist(sortedArray, targetSum);
        Console.WriteLine($"Does sum exist: {doesSumExist}");
    }

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