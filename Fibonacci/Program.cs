using System;

class program
{
    static void Main()
    {
        // // Fibonacci number using a for loop
        int old_value = 0;
        int older_value = 1;
        int n = 10;

        for (int i = 2; i <= n; i++)
        {
            int newValue = old_value + older_value;
            Console.WriteLine("F" + i + ": " + newValue);
            old_value = older_value;
            older_value = newValue;
        }

        Console.WriteLine("--------------------");

        // Fibonacci number using recursion
        void fibonacci(int prev, int prev1, int count)
        {
            if (count <= 19)
            {
                int new_value = prev + prev1;
                Console.WriteLine("F" + count + ": " + new_value);
                fibonacci(prev1, new_value, count + 1);
            }
        }

        fibonacci(0, 1, 2);
        Console.WriteLine("--------------------");

        //Another method
        int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        Console.WriteLine(Fibonacci(2));
        Console.WriteLine(Fibonacci(3));
        Console.WriteLine(Fibonacci(4));
        Console.WriteLine(Fibonacci(5));
        
        //Addressing overlapping subproblem with memoization
        static int Fib(int n, Dictionary<int, int> memo)
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
        Dictionary<int, int> memo = new Dictionary<int, int>();
        Console.WriteLine("Memoization: " + Fib(10, memo));
        Console.WriteLine("------------");
            
        static int FibIteration(int n)
        {
            if (n == 0)
                return 0;

            // a and b start with the first two numbers in the series
            int a = 0;
            int b = 1;

            // Loop from 1 until n
            for (int i = 1; i < n; i++)
            {
                // a and b each move up to the next numbers in the series
                int temp = a;
                a = b;
                b = temp + a;
            }

            return b;
        }
        Console.WriteLine("Iteration: " + FibIteration(10));

    }
}