namespace Complexity_Analysis;

public class CocktailShakerSortAlgorithm
{
    /*CocktailShakerSort (A):
        start ← 0
        end ← length(A) - 1
        swapped ← true

    while swapped do
        swapped ← false

        for i from start to end - 1 do
            if A[i] > A[i+1] then
                swap Ai], A[i+1]
                swapped ← true

    if swapped = false then break

    swapped ← false
    end ← end - 1

    for i from end down to start + 1 do
        if A[i-1] > A[i] then
            swap A[i-1], A[i]
            swapped ← true

    start ← start + 1
    */
    
   public void CocktailShakerSort(int[] A)
   {
       int start = 0;
       int end = A.Length - 1;
       bool swapped = true;

       while (swapped)
       {
           swapped = false;

           // Forward pass: left to right
           for (int i = start; i < end; i++)
           {
               if (A[i] > A[i + 1])
               {
                   (A[i], A[i + 1]) = (A[i + 1], A[i]);
                   swapped = true;
               }
           }

           if (!swapped)
               break; // inside the while loop

           swapped = false;
           end = end - 1;

           // Backward pass: right to left
           for (int i = end; i > start; i--) // fixed: i > start
           {
               if (A[i - 1] > A[i])
               {
                   (A[i], A[i - 1]) = (A[i - 1], A[i]);
                   swapped = true;
               }
           }

           start = start + 1;
           
       }
   }
   
}