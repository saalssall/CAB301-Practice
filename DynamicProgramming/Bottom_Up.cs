using static System.Console;
namespace Dynamic_Programming;

public class Bottom_Up
{
    /*
     * Bottom up strategy using recursion
     */

    int recursion_bu(int n, int index = 1, int product = 1)
    {
        if (index >= n)
        {
            return product;
        }
        return recursion_bu(n, index + 1, product * index);
    }

    public void Run()
    {
        WriteLine(recursion_bu(2));
        WriteLine("------------");
    }
    
}