using System;
namespace Sorts;

public class BubbleSortAlgorithm
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
    
    public void bubbleSort (int [] A, int n)
    {
        bool swwapped;
        
        for (int i = 0; i < n - 1; i++)
        {
            swwapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (A[j] > A[j + 1])
                {
                    //Deconstruction
                    (A[j], A[j + 1] ) = (A[j + 1], A[j]);
                    swwapped = true;
                }
            }
            if (!swwapped)
            {
                break;
            }
        }
    }
}