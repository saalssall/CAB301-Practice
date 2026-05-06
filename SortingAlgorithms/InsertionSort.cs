namespace Sorts;

public class InsertionSortAlgorithm
{
    /*
     ALGORITHM InsertionSort(A[0..n − 1])
       // Sorts array A in nondecreasing order
       for i <- 1 to n − 1 do
          v <- A[i]
          j <- i − 1
          while j ≥ 0 and A[j] > v do
             A[j + 1] <- A[j]
             j <- j − 1
          A[j + 1] <- v
     */
    
    public void InsertionSort(int[] A, int n)
    {
        for (int i = 1; i < n; i++)
        {
            int v = A[i];
            int j = i - 1;

            while (j >= 0 && A[j] > v)
            {
                A[j + 1] = A[j];
                j = j - 1;
            }
            A[j + 1] = v;
        }
    }
}
