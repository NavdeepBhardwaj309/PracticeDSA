using myprogressapp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myprogressapp1.Algorithms.Sorting
{
    internal class InsertionSort : IProgramInterface
    {
        public void ExecuteProgram()
        {
            int[] arr1 = [7, 4, 2, 5, 3,1];
            if (arr1 != null)
            {
                Console.WriteLine("resulted array");

                foreach (var element in getInsertionSortArray(arr1))
                {
                    Console.WriteLine(element);
                }
            }
        }
        // compare the element with sorted array elements. if it is less than the any value insert it.
        // arr with length 1 is sorted itslef, so start from the second elemt arr[1]and comapre it backward till the index become 0. in this case if j=1 then comapre with j= 0 i.e fist element arr[0]. 
        // make element a key and comapre with it. why i can't use arr[j]>arr[i] because arr[i] can be changed after swapping. 
        private int[] getInsertionSortArray(int[] arr)
        {


            if (arr.Length <= 1)
            {
                return arr;
            }


            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];

                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[j] > key)

                    {

                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;


                    }

                }

            }

            return arr;
        }
    }
}
