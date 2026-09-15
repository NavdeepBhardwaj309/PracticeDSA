using myprogressapp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace myprogressapp1.Algorithms.Searching
{
    //problem :find the index of given number in the sorted array
    // binary search can be applied if the array is sorted
    // break the array in half, if the element is greater than middle element, then search in right half  else in letf half.
    // again repeat this process in the selected half array untill you find the number, 
    //return -1 if element does not found
    //Time Complexity: 𝑂(log𝑛)


    public class BinarySearch : IProgramInterface
    {
        public void ExecuteProgram()
        {
            int[] arr =  [2, 5, 7, 8, 9, 13, 15, 16, 17, 20,22];
           int index= GetElement(arr, 13);
            Console.WriteLine($"index of give element is { index}");
        }

        public int GetElement(int[] arr, int num)
        {

            if (arr == null || arr.Length == 0)
            {
                return -1; 
            }
            
            int left = 0;
            int right = arr.Length - 1;
            int index = DoBinarySearch(arr, left, right, num);


            return index;
        }

        public int DoBinarySearch(int[] arr, int left,  int right, int num)
        {
            if (left > right)
            {
                return -1;
            }
            int  mid = left + (right - left) / 2;
            Console.WriteLine($"left, mid, and right is { left}, { mid}, { right}");
           
            
            if (arr[mid]==num)
            {
              return mid;
            }
            if (arr[mid]> num)
            { 
               right = mid-1;
            }
            else
            {
               left = mid+1;
            }
           
            return DoBinarySearch(arr, left, right, num);
           
        }
    }
}
 
