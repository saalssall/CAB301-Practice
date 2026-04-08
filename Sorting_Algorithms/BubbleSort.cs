using System;
namespace Sorts;

public class BubbleSort
{
    public static void bubbleSort(int[] arr)
    {
        /*** 1. Bubble sort (sorting elements in an array from lowest to highest)
        Input: numbers from the array
        Output: sorted array from lowest to highest

        Steps:
        1. Go through the elements in the array one by one
        2. For each value, compare it with the next value
        //If the value is higher, swap the values so that the higher value comes last
        3. Go through all the elements in the array
        4. Print the sorted array

        Pseudocode:
        bubbleSort(A, n)

        for i ← 0 to n - 2 do
           swapped ← false

           for j ← 0 to n - i - 2 do
               if A[j] > A[j + 1] then
                   swap A[j] and A[j + 1]
                   swapped ← true
               end if
           end for
           if swapped = false then
               break
           end if
        end for

        return A
        ***/

        int[] sortArray = { 12, 43, 44, 3, 11, 49 };
        int n = sortArray.Length;
        for (int i = 0; i < n - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (sortArray[j] > sortArray[j + 1])
                {
                    int temp;
                    temp = sortArray[j];
                    sortArray[j] = sortArray[j + 1];
                    sortArray[j + 1] = temp;
                    swapped = true;
                }
            }

            if (!swapped)
            {
                break;
            }
        }
    }
}