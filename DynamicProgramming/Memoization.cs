using static System.Console;
namespace Dynamic_Programming;

public class Memoization
{
    // Addressing overlapping subproblem with memoization
    int Fib(int n, Dictionary<int, int> memo)
    {
        // Base case
        if (n == 0 || n == 1)
            return n;

        // Check if fib(n) was already computed
        if (!memo.ContainsKey(n))
        {
            // If not in memo, compute and store it
            memo[n] = Fib(n - 2, memo) + Fib(n - 1, memo);
        }

        // Return the result from memo
        return memo[n];
    }

    static int FibIteration(int n)
    {
        if (n == 0)
            return 0;

        int a = 0;
        int b = 1;

        for (int i = 1; i < n; i++)
        {
            int temp = a;
            a = b;
            b = temp + a;
        }

        return b;
    }

    
    public void Run()
    {
        Dictionary<int, int> memo = new Dictionary<int, int>();
        WriteLine("Memoization: " + Fib(10, memo));
        WriteLine("------------");
        WriteLine("Iteration: " + FibIteration(10)); 
        WriteLine("------------");
    }
}