
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
            
            int[] sortedArray4Bubble = { 1, 2, 3, 4, 5, 6 };
            int[] unsortedArray = { 38, 12, 45, 5, 23, 2, 67, 16, 90, 8 };
            int[] unsortedArray4Selection = { 38, 12, 45, 5, 23, 2, 67, 16, 90, 8 };
            
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
            
            //Calling the insertion sort algorithm
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
            
            //Calling the merge sort algorithm
            MergeSortAlgorithm mergeSort = new MergeSortAlgorithm();
            Console.WriteLine("Before merge sort:");
            PrintArray(unsortedArray);
            int[] sorted = mergeSort.Sort(unsortedArray);
            Console.WriteLine("After merge sort:");
            PrintArray(sorted);
            Console.WriteLine("---------------");
            
            //Calling the bubble sort algorithm on unsorted array
            BubbleSortAlgorithm bubbleSort = new BubbleSortAlgorithm();
            Console.WriteLine("Before bubble sort:");
            PrintArray(sortedArray4Bubble);
            Console.WriteLine("After bubble sort:");
            bubbleSort.bubbleSort(sortedArray4Bubble,  sortedArray4Bubble.Length);
            PrintArray(sortedArray4Bubble);
            Console.WriteLine("---------------");
            
            //Calling the bubble sort algorithm on unsorted array
            Console.WriteLine("Before bubble unsorted:");
            PrintArray(unsortedArray);
            Console.WriteLine("After bubble unsorted:");
            bubbleSort.bubbleSort(unsortedArray,  unsortedArray.Length);
            PrintArray(unsortedArray);
            Console.WriteLine("---------------");
            
            //Calling the selection sort algorithm
            SelectionSortAlgorithm selectionSort = new SelectionSortAlgorithm();
            Console.WriteLine("Before selection sort:");
            PrintArray(unsortedArray4Selection);
            Console.WriteLine("After selection sort:");
            selectionSort.SelectionSort(unsortedArray4Selection,  unsortedArray4Selection.Length);
            PrintArray(unsortedArray4Selection);
            

        }
    }
}
            