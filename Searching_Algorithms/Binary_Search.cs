namespace Searching_Algorithms;

public class Binary_Search
{
    public int binary_search(int[] array, int searchValue)
    {
        int lower_bound = 0;
        int upper_bound = array.Length - 1;

        while (lower_bound <= upper_bound)
        {
            int mid_point = (lower_bound + upper_bound) / 2;
            int value_at_midpoint = array[mid_point];
            if (searchValue == value_at_midpoint)
            {
                return mid_point;
            }
            if (searchValue < value_at_midpoint)
            {
                upper_bound = mid_point - 1;
            }
            else if (searchValue > value_at_midpoint)
            {
                lower_bound = mid_point + 1;
            }
        }

        return -1; //not found
    }
}