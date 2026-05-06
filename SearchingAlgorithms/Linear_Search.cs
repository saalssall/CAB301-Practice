namespace Searching_Algorithms;

public class Linear_SearchAlgorithm
{
    public int Linear_Search(int[] A, int search_Value)
    {
        for (int index = 0; index < A.Length; index++)
        {
            //If we found the value we are looking for, we return its index
            if (A[index] == search_Value)
            {
                return index;
            }
            //If we reach an element that is greater than the value we are looking for, we can exit the loop early 
            if (A[index] > search_Value)
            {
                break;
            }
        }
        return -1;
    }
}