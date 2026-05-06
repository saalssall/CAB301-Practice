namespace Sorts;

public class MergeSortAlgorithm
{
    /*
     MergeSort(A)
       if length(A) <= 1 then
       return A
       mid <- floor(length(A) / 2)
       left <- MergeSort(A[0..mid-1])
       right <- MergeSort(A[mid..end])
       return Merge(left, right)
       Merge(left, right)
       result <- empty list
       i <- 0
       j <- 0
       while i < length(left) and j < length(right) do
       if left[i] <= right[j] then
       append left[i] to result
       i <- i + 1
       else
       append right[j] to result
       j <- j + 1
       append remaining elements of left
       append remaining elements of right
       return result
       */

        public int[] Sort(int[] A)
        {
            // Base case - if array has 1 or 0 elements, it's already sorted
            if (A.Length <= 1)
                return A;

            // Find the middle point
            int mid = A.Length / 2;

            // Split array into left and right halves
            int[] left = new int[mid];
            int[] right = new int[A.Length - mid];

            Array.Copy(A, 0, left, 0, mid);
            Array.Copy(A, mid, right, 0, A.Length - mid);

            // Recursively sort each half
            left = Sort(left);
            right = Sort(right);

            // Merge the sorted halves
            return Merge(left, right);
        }

        public int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int i = 0, j = 0, k = 0;

            // Compare elements from both halves and merge in order
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    result[k] = left[i];
                    i++;
                }
                else
                {
                    result[k] = right[j];
                    j++;
                }
                k++;
            }

            // Append remaining elements from left (if any)
            while (i < left.Length)
            {
                result[k] = left[i];
                i++; k++;
            }

            // Append remaining elements from right (if any)
            while (j < right.Length)
            {
                result[k] = right[j];
                j++; k++;
            }

            return result; 
        } 
}
