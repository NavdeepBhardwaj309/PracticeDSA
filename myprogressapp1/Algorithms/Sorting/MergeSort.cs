using myprogressapp1.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myprogressapp1.Algorithms.Sorting
{
    public class MergeSort : IProgramInterface
    {
        public void ExecuteProgram()
        {
            int[] arr1 = [10, 1, 1, 12, 3,17,4,2,15,5,8,20,25];
            if (arr1 != null && arr1.Length > 0)
            {

                int len1 = arr1.Length;

                int[] arr = getMergeSortrray(arr1);
                Console.WriteLine("resulted array");

                foreach (var element in arr)
                {
                    Console.WriteLine(element);
                }
            }


        }

        private int[] getMergeSortrray(int[] arr1)
        {
            return DivideAndConquer(arr1);
        }

        
        private int[]  DivideAndConquer(int[] arr)
        {
            if(arr.Length<=1)
            {
                return arr;
            }


            int mid = arr.Length / 2;
            int [] leftHalf = new int[mid];
            int[] rightHalf = new int[arr.Length - mid];
            // Copy method by array in c#
            // params=> source arr, source index from here arr starts, destination arr, destination arr starting index, destination arr length

            Array.Copy(arr, 0, leftHalf, 0, mid); 
            Array.Copy(arr, mid, rightHalf, 0, arr.Length-mid);

            // Manual way to copy array
            //for(int i=0;i<mid;i++)
            //{
            //    leftHalf[i] = arr[i];
            //}
            //for (int j = mid; j < arr.Length; j++)
            //{
            //    rightHalf[j - mid] = arr[j];
            //}
            int[] sortedLeft = DivideAndConquer(leftHalf);
            int[] sortedRight = DivideAndConquer(rightHalf);

            return mergeByTwoPointTechnique(sortedLeft, sortedRight, sortedLeft.Length, sortedRight.Length);

        }


        private int[]  mergeByTwoPointTechnique(int[] leftArr, int[] rightArr, int len1, int len2)
        { 
            int i = 0;
            int j = 0; 
            int k = 0;
            int[] sortedArr=new int[len1+len2];
            while(i<len1 && j<len2)
            {
                if (leftArr[i] < rightArr[j])
                {
                    sortedArr[k] = leftArr[i];
                    i++;
                    k++;
                }
                else if(leftArr[i] > rightArr[j])
                {
                    sortedArr[k] = rightArr[j];
                    j++;
                    k++;
                }
                else if (leftArr[i] == rightArr[j])
                {
                    sortedArr[k] = leftArr[i];
                    i++;
                    k++;
                    sortedArr[k] = rightArr[j];
                    j++;
                    k++;
                }
            }
            while(i<len1)
            {
                sortedArr[k] = leftArr[i];
                i++;
                k++;
            }
            while (j < len2)
            {
                sortedArr[k] = rightArr[j];
                j++;
                k++;
            }
            return sortedArr;
        }
    }
}
