using myprogressapp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myprogressapp1.Algorithms.Sorting
{
    public class MergeSortedArrayTwoPointTech : IProgramInterface
    {
        public void ExecuteProgram()
        {
            int[] arr1 = [1, 2, 3, 4, 10,11];
            int[] arr2 = [3, 5, 6, 7, 8,12];
            int len1 = arr1.Length;
            int len2 = arr2.Length;
            int[] arr = getMergedSortesArray(arr1, arr2, len1, len2);
            Console.WriteLine("resulted array");
            foreach (var element in arr)
            {
                Console.WriteLine(element);
            }
        }
        public int[] getMergedSortesArray(int[] arr1, int[] arr2, int len1, int len2)
        {
            int[] arr = new int[len1 + len2];
            int i = 0, j = 0;
            int k = 0;
            Console.WriteLine($"before while {len1}, {len2}");
            while (i < len1 && j < len2)
            {

                if (arr1[i] > arr2[j])
                {
                    arr[k] = arr2[j];
                    j++;
                    k++;
                }
                else if (arr1[i] < arr2[j])
                {
                    arr[k] = arr1[i];
                    i++;
                    k++;
                }
                else if (arr1[i] == arr2[j])
                {
                    arr[k] = arr1[i];
                    i++;
                    j++;
                    k++;
                }
               

                Console.WriteLine($"in while, {i}, {j}  {arr[k]}");

            }
            
               while(i < len1) {
                    arr[k] = arr1[i];
                    i++;
                    k++;
                }
            
            
                while (j < len1)
                {
                    arr[k] = arr2[j];
                    j++;
                    k++;
                }

            
            return arr;
        }
    }
}
