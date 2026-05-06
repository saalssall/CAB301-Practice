namespace Sorts;

public class QuickSortAlgorithm
{
    
    /* Pseudocode:
     1. QuickSort(A, low, high)
      if low < high then
          p <- Partition (A, low, high)
          QuickSort(A, low, p - 1)
          QuickSort(A, p + 1, high)

      Partition(A, low, high)
          pivot <- A[high]
          i <- low - 1
          for j <- low to high - 1 do
              if A[i] <= pivot then
                  i <- i + 1
                  swap A[i] and A[j]
          swap A[i + 1] and A[high]
          return i + 1;

                 ***/

    public static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int p = Partition(arr, low, high);

            QuickSort(arr, low, p - 1);
            QuickSort(arr, p + 1, high + 1);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;
        for (int j = low; j <= high - 1; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                Swap(arr, i, j);
            }
        }
        Swap(arr, i + 1, high);
        return i + 1;
    }
        
    static void Swap(int[] arr, int a, int b)
    {
        (arr[a], arr[b]) = (arr[b], arr[a]);
    }
    
}