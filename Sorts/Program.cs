
using System;
namespace Sorts
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortArray = { 12, 43, 44, 3, 11, 49 };
            int n = sortArray.Length;
            
            // Calling the quicksort function
            QuickSort1.QuickSort(sortArray, 0, sortArray.Length - 1);
            foreach (int value in sortArray)
            {
                Console.Write(value + ", ");
            }
            
            // Calling the bubble sort function
            BubbleSort.bubbleSort(sortArray);
        }
    }
}