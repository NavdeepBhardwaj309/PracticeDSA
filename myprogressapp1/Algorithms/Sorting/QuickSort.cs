using myprogressapp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace myprogressapp1.Algorithms.Sorting
{
    internal class QuickSort : IProgramInterface
    {
        private static Random random = new Random();
        public void ExecuteProgram()
        {
            int[] arr1 = [7, 4, 2, 5, 3];
            if (arr1 != null)
            {
                Console.WriteLine("resulted array");
                //  getQuickSortArray(arr1, 0, arr1.Length - 1);
                //getQuickSortArrayAtAnyIndex(arr1, 0, arr1.Length - 1, arr1.Length - 3);
               getQuickSortArrayAtAnyIndex(arr1, 0, arr1.Length - 1);// given pivot point null
                foreach (var element in arr1)
                {
                    Console.WriteLine(element);
                }
            }
        }


        // take an element,could be from any index, as pivot.
        // element greter than pivot goes to rightarray
        // elememt smaller than pivot goes to leftarray
        //best approach is to pivot last element, but it need more swaps
        // if mid is pivot then no. of swaps are less.
        // if you take any index element as pivot, then to make it easy, frst swap it   with last element and then pivot it at last index.
        private void getQuickSortArrayAtAnyIndex(int[] arr, int left, int right, int? givenPivotIndex = null)
        {
            if (left >= right) return;
            int pivotIndex = right;// default assignment to last index
            if (givenPivotIndex != null)
            { //INCASE OF GIVEN PIVOT INDEX
                pivotIndex = (int)givenPivotIndex;
            }
            else
            {
                //incase of last index as pivot
                // pivotIndex =right;

                //incase of start( left or 0 )index as pivot
                // pivotIndex =left;

                //incase of mid index as pivot
                pivotIndex = left + (right - left) / 2;

                //incase of random index between left and right  as pivot
                //pivotIndex = random.Next(left, right + 1);

            }

            int partitionIndexOfPivot = PartitionAtAnyIndex(arr, left, right, pivotIndex);

            //    getQuickSortArrayAtAnyIndex(arr, left, partitionIndexOfPivot - 1, partitionIndexOfPivot - 1); // last index as given pivot point
            //    getQuickSortArrayAtAnyIndex(arr, partitionIndexOfPivot + 1, right,right); //last indes as given pivot point

            getQuickSortArrayAtAnyIndex(arr, left, partitionIndexOfPivot - 1); //  given pivot point null
            getQuickSortArrayAtAnyIndex(arr, partitionIndexOfPivot + 1, right); // given pivot point null


        }



        private int PartitionAtAnyIndex(int[] arr, int left, int right, int pivotIndex)
        {
            int pivot = arr[pivotIndex];
            if (right != pivotIndex)// pivot index not equal to last index
            {
                Swap(arr, pivotIndex, right); // move the pivot to last index;
            }
            int i = left - 1;
            int j = left;
            while (j < right)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
                j++;
            }
            Swap(arr, i + 1, right);
            return i + 1;
        }


        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }


        // incase of mid pivot point, without swapping it with last index
        private int Partition(int[] arr, int left, int right)
        {
            int mid = left + (right - left) / 2; // Middle index
            int pivot = arr[mid]; // Use middle element as pivot

            int i = left, j = right; // Start two pointers

            while (i <= j)
            {
                while (arr[i] < pivot) i++; // Move i until element >= pivot
                while (arr[j] > pivot) j--; // Move j until element <= pivot

                if (i <= j) // Swap elements that are out of place
                {
                    Swap(arr, i, j);
                    i++;
                    j--;
                }
            }

            return i; // Return partition index
        }

        private void getQuickSortArray(int[] arr, int left, int right)
        {
            if (left >= right) return; // Base case

            int partitionIndexOfPivot = PartitionAtLastIndex(arr, left, right); // Partition the array
            // when recursion call wil take place, it will again choose last element of the array as pivot and do the sorting
            getQuickSortArray(arr, left, partitionIndexOfPivot - 1); // Sort left half =>from index 0 to pivotindex -1, as pivot is already on its place, now ony need to sort element less than pivot
            
            getQuickSortArray(arr, partitionIndexOfPivot + 1, right); // Sort right half =>from index pivotIndex +1 to array.length-1, as pivot is already on its place, now only need to sort elements greater than pivot
           
        }


        //partition rearrange element across the pivot , element<pivot on left side and element >pivot on right side
        // resulted array need not to be always sorted
        //return the new index of the pivot element after re-arrangement
        private int PartitionAtLastIndex(int[] arr, int left, int right)  
        {
            int pivot = arr[right];
            int i = left - 1; // Position for swapping, initially -1, i.e no postion

            for (int j = left; j < right; j++)
            {
                if (arr[j] <= pivot) // Move elements smaller than pivot to the left
                {
                    i++; // increase the position index by one till all the elements less than pivot are placd left of pivot
                    Swap(arr, i, j);  // swapping the jth element(smaller one) with ith index element(larger then pivot)
                }
            }

            Swap(arr, i + 1, right); //at the end when all smaller elements than pivot are placed left side, then place the pivot element before the  smallest of larger elements

            return i + 1; // Return pivot index
        }





      
        private int PartitionAtLastIndexUsingWileLoop(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;
            int j = left;

            while (j < right)
            {
                if (arr[j] <= pivot)
                {
                    i++;

                    Swap(arr, i, j);

                }
                j++;
            }
            Swap(arr, i + 1, right);
            return i + 1;
        }

    }  
}
