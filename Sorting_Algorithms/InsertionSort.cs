namespace Sorts;

public class InsertionSortAlgorithm
{
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
