using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myprogressapp1.Interfaces;
namespace myprogressapp1.Algorithms.Sorting
{
    public class BucketSort : IProgramInterface
    {
        public void ExecuteProgram()
        {
            Console.WriteLine("ExecuteProgram");
            float[] arr1 = [.7f, .4f, .2f, .5f, .3f, .32f];
            if (arr1 != null)
            {

                int len1 = arr1.Length;

                getBucketArray(arr1, len1);
                Console.WriteLine("resulted array");

                foreach (var element in arr1)
                {
                    Console.WriteLine(element);
                }
            }

        }
        public void getBucketArray(float[] arr, int len)
        {
            List<float>[] buckets = new List<float>[len];

            for (int i = 0; i < len; i++)
            {
                buckets[i] = new List<float>();
            }
            for (int i = 0; i < len; i++)
            {
                int bucketIndex = (int)(len * arr[i]);
                buckets[bucketIndex].Add(arr[i]);

            }
            for (int i = 0; i < len; i++)
            {
                InsertionSort(buckets[i], buckets[i].Count());
            }
            int index = 0;
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < buckets[i].Count(); j++)
                {
                    arr[index] = buckets[i][j];
                    index++;
                }

            }

        }

        public void InsertionSort(List<float> bucket, int bLen)
        {
            if (bLen <= 1)
                return;
            for (int i = 1; i < bLen; i++)
            {
                float key = bucket[i];
                for (int j = i - 1; j >= 0; j--)
                {

                    if (bucket[j] > key)
                    {

                        bucket[j + 1] = bucket[j];

                    }
                }
                bucket[i] = key;
            }
        }

    }
}
