using Microsoft.Extensions.DependencyInjection;
using myprogressapp1.Algorithms.Searching;
using myprogressapp1.Algorithms.Sorting;
using myprogressapp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myprogressapp1.Factory
{
    public class ProgramFactory
    {
        private  readonly IServiceProvider _serviceProvider;
        public ProgramFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IProgramInterface ExecuteProgram(string programName)
        { 
            switch (programName)
            {
                case "MergeSortedArray":
                    return _serviceProvider.GetService<MergeSortedArrayTwoPointTech>();
                case "BinarySearch":
                    return _serviceProvider.GetService<BinarySearch>();
                case "LinearSearch":
                    return _serviceProvider.GetService<LinearSearch>();
                case "SelectionSort":
                    return _serviceProvider.GetService<SelectionSort>();
                case "BubbleSort":
                    return _serviceProvider.GetService<BubbleSort>();
                case "MergeSort":
                    return _serviceProvider.GetService<MergeSort>();
                case "InsertionSort":
                    return _serviceProvider.GetService<InsertionSort>();
                case "QuickSort":
                    return _serviceProvider.GetService<QuickSort>();
                case "HeapSort":
                    return _serviceProvider.GetService<HeapSort>();
                default:
                    throw new ArgumentException("Invalid program name");
            }
        }
    } 
}
