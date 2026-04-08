
using System;
namespace Sorts
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortedArray = { 12, 43, 44, 3, 11, 49 };
            int [] reversedArray = {12, 11, 10, 9, 8, 7, 6, 5};
            int [] randomArray = {32, 11, 44, 2, 43, 22};
            
            int n = sortedArray.Length;
            // Calling the quicksort function
            // QuickSort1.QuickSort(sortedArray, 0, sortedArray.Length - 1);
            // foreach (int value in sortedArray)
            // {
            //     Console.Write(value + ", ");
            // }
            
            //Having a method for printing the array for insertion sort
            void PrintArray(int[] A)
            {
                Console.Write("[");
                Console.Write(A[0]);

                for (int i = 1; i < A.Length; i++)
                {
                    Console.Write(", " + A[i]);
                }
                Console.Write("]");
                Console.WriteLine();
            }
            
            //Calling the insertion sort
            InsertionSortAlgorithm insertionSort = new InsertionSortAlgorithm(); 
            
            Console.WriteLine("Sorted before:");
            PrintArray(sortedArray);
            Console.WriteLine("Sorted after:");
            insertionSort.InsertionSort(sortedArray, sortedArray.Length);
            PrintArray(sortedArray);
            
            Console.WriteLine("---------------");
            Console.WriteLine("Reversed before:");
            PrintArray(reversedArray);
            Console.WriteLine("Reversed after:");
            insertionSort.InsertionSort(reversedArray, reversedArray.Length);
            PrintArray(reversedArray);
            
            Console.WriteLine("---------------");
            Console.WriteLine("Random before:");
            PrintArray(randomArray);
            Console.WriteLine("Random after:");
            insertionSort.InsertionSort(randomArray, randomArray.Length);
            PrintArray(randomArray);
            

        }
    }
}
            