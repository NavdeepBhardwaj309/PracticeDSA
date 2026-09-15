using myprogressapp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace myprogressapp1.Algorithms.Sorting
{
    public class HeapSort : IProgramInterface
    {
       
        public void ExecuteProgram()
        {
            int[] arr1 = [7, 4, 2, 5, 3];
            if (arr1 != null)
            {
                Console.WriteLine("resulted array");
                //  getQuickSortArray(arr1, 0, arr1.Length - 1);
                //getQuickSortArrayAtAnyIndex(arr1, 0, arr1.Length - 1, arr1.Length - 3);
                getHeapSortArray(arr1, arr1.Length - 1);// given pivot point null
                foreach (var element in arr1)
                {
                    Console.WriteLine(element);
                }
            }
        }



        //     bring the largest element to the parent  node by using max heap
        //   i=len/2-1, left child=2i+1, right child at index =2i+2
        //we will not take leaf node, as they dont have child element so they do not have any child eleemt to compare and bring it to node.
        //how we reach at i=len/2-1, our i should be such that its left and right child should not get out of index. that mean 2i+1<=n 0r 2i+2<=2
        //arr1 = [7, 4, 2, 5, 3], len=5,  2i+1<=5  => i<=2, if i is >2,say 3 then 2*3+1=7, which become out of range.
        // start from i=len/2-1
        //after every heapify, swap the largest element with the smallest element

        public void getHeapSortArray(int[] arr, int len)
        {            
            for(int i= len/2-1; i>=0;i--)
            {
                Heapify(arr, len, i);
            }
            for(int newlen = len - 1; newlen > 0; newlen--) //after heapify arr will have largest element at index 0, swap it with last index, and reduce the length by 1
            {
                int temp = arr[0];
                arr[0]= arr[newlen];// last index=len-1
                arr[newlen]= temp;
                Heapify(arr, newlen, 0); // new length of arr after reducing length by i=newlen i.e len-1; 
            }
            
        }

        public void Heapify(int[] arr, int len, int index)
        {
            int largest = index; // index of node, assuming node has largest value
            int l = 2 * index + 1; // left child node
            int r = 2 * index + 2;// right child node
            if (l < len && arr[l] > arr[largest])
            {
                largest= l;
            }
            if (r < len && arr[r] > arr[largest])
            {
                largest = r;
            }
            if (largest != index)
            {
                int temp = arr[index];
                arr[index]= arr[largest];
                arr[largest]= temp;
                Heapify(arr, len, largest); // new index =largest as it have updaed index where largest element
            }
        }

    }
    }
