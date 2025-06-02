using Microsoft.Extensions.DependencyInjection;
using myprogressapp1.Algorithms.Searching;
using myprogressapp1.Algorithms.Sorting;
using myprogressapp1.Factory;
using myprogressapp1.Interfaces;
using System;
using System.Threading.Tasks;

namespace myprogressapp1
{
    internal class Program
    {


        /// <summary>
        /// this will execute all the program once application is launched
        /// to add new program impelemnet  .AddSingleton<IProgram, MergeSortedArray>()
        /// </summary>
        /// <param name="args"></param>
        //static void Main(string[] args)
        //{
        //    var serviceProvider = new ServiceCollection()
        //        .AddSingleton<IProgram, MergeSortedArray>()
        //        .BuildServiceProvider();

        //    var tasks = serviceProvider.GetServices<IProgram>();
        //    foreach (var task in tasks)
        //    {
        //        task.Execute();
        //    }
        //}



        /// <summary>
        /// to execute one task at a time depending on the user input
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
               .AddSingleton<MergeSortedArrayTwoPointTech>()
               .AddSingleton<BinarySearch>()
               .AddSingleton<LinearSearch>()
               .AddSingleton<SelectionSort>()
               .AddSingleton<BubbleSort>()
               .AddSingleton<MergeSort>()
               .AddSingleton<InsertionSort>()
               .AddSingleton<QuickSort>()
               .AddSingleton<HeapSort>()
               .AddSingleton<BucketSort>()
               .AddSingleton<ProgramFactory>()
                .BuildServiceProvider();
           
        
            var program = serviceProvider.GetService<ProgramFactory>();
            AlgoEnum algo = AlgoEnum.BucketSort;
            IProgramInterface prog = program.ExecuteProgram(algo.ToString());

            prog.ExecuteProgram();
        }
    }
}
