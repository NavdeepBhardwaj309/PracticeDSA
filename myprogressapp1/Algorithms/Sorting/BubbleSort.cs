using myprogressapp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myprogressapp1.Algorithms.Sorting
{
    public class BubbleSort : IProgramInterface
    {
        public void ExecuteProgram()
        {
            int[] arr1 = [7, 4, 2, 5, 3];
            if (arr1 != null)
            {

                int len1 = arr1.Length;

                int[] arr = getBubbleSortArray(arr1, len1);
                Console.WriteLine("resulted array");

                foreach (var element in arr)
                {
                    Console.WriteLine(element);
                }
            }

        }

        private int[] getBubbleSortArray(int[] arr1, int len)
        {

            int[] temparr = new int[len];
            for (int i = 0; i < len - 1; i++)
            {
                for (int j = 0; j < len - i - 1; j++)
                {
                    if (arr1[j] > arr1[j + 1])
                    {
                        int temp = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = temp;
                    }
                }

            }


            return arr1;
        }
    }
}
