using myprogressapp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace myprogressapp1.Algorithms.Searching
{
    // USAGE:
//    Unsorted Lists: When we have an unsorted array or list, linear search is most commonly used to find any element in the collection.
//Small Data Sets: Linear Search is preferred over binary search when we have small data sets with
//Searching Linked Lists: In linked list implementations, linear search is commonly used to find elements within the list. Each node is checked sequentially until the desired element is found.
//Simple Implementation: Linear Search is much easier to understand and implement as compared to Binary Search or Ternary Search.
    public class LinearSearch : IProgramInterface
    {
        public void ExecuteProgram()
        {
            int[] arr = [2, 5, 7, 8, 9, 13, 15, 16, 17, 20, 22];
            int index = GetElement(arr, 10);
            Console.WriteLine($"index of give element is {index}");
        }

        private int GetElement(int[] arr, int num)
        {

            if (arr == null || arr.Length == 0)
            {
                return -1;
            }
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                  index=i; 
                   break;
                }
            }


            return index;
        }
    }
}
