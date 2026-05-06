namespace Sorts;

public class SelectionSortAlgorithm
{
    /* Pseudocode:

     selectionSort(A, n)
        for i ← 0 to n - 2 do
            lowestValue ← i

            for j ← i + 1 to n - 1  do
                if A[j] < A[lowestValue] then
                    lowestValue = j
                end if
            end for

            if lowestValue ≠ i then
                temp = A[i]
                A[i] = A[lowestValue]
                A[lowestValue] = temp
             end if
        enf for
    return A

     */

    public int[] SelectionSort(int[] A, int n)
    {
        for (int i = 0; i < n - 1; i++)
        {
            int lowestValue = i;

            // Find the smallest element in the remaining array
            for (int j = i + 1; j < n; j++)
            {
                if (A[j] < A[lowestValue])
                {
                    lowestValue = j;
                }
            }

            // Swap if a smaller element was found
            if (lowestValue != i)
            {
                (A[i], A[lowestValue]) = (A[lowestValue], A[i]);
            }
        }

        return A;
    }
}