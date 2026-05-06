namespace Complexity_Analysis;

public class JumpSearchAlgorithm
{
    /*
     JumpSearch (A, key) :
       n ← length (A)
       j ← floor (sqrt (n))
       if j ← 1 then j + 1
       start ← 0
       end ← j
       
       while start ← n AND A[min(end, n) - 1] ‹ key do
            start ← end
            end ← end + j
            if start ≥ n then return -1
            
       for i from start to min(end, n) - 1 do
            if A[i] = key then return i
            if A[i] > key then break // because A is sorted
            
     return -1
     
     */

    public int JumpSearch(int[] A, int key)
    {
        int n = A.Length;
        int j = (int)Math.Sqrt(n);

        if (j == 1)
            j++;

        int start = 0;
        int end = j;

        while (start < n && A[Math.Min(end, n) - 1] < key)
        {
            start = end;
            end = end + j;

            if (start >= n)
                return -1;
        }

        // - 1 is correct here, matching the pseudocode
        for (int i = start; i <= Math.Min(end, n) - 1; i++)
        {
            if (A[i] == key)
                return i;

            if (A[i] > key)
                break;
        }

        return -1;
    }
}