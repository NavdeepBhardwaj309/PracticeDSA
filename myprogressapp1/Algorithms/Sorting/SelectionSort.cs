using myprogressapp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myprogressapp1.Algorithms.Sorting
{
    

        public class SelectionSort : IProgramInterface
        {
            public void ExecuteProgram()
            {
                int[] arr1 = [7, 4, 2, 5, 3];
                if (arr1 != null)
                {

                    int len1 = arr1.Length;

                    int[] arr = getSelectionSortArray(arr1, len1);
                    Console.WriteLine("resulted array");

                    foreach (var element in arr)
                    {
                        Console.WriteLine(element);
                    }
                }

            }

            private int[] getSelectionSortArray(int[] arr1, int len)
            {

                int[] temparr = new int[len];
                for (int i = 0; i < len - 1; i++)
                {
                    for (int j = i + 1; j < len; j++)
                    {
                        if (arr1[i] > arr1[j])
                        {
                            int temp = arr1[i];
                            arr1[i] = arr1[j];
                            arr1[j] = temp;
                        }
                    }

                }


                return arr1;
            }
        }
    
}
