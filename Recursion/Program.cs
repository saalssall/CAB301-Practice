// Practicing the concept of recursion
using System;
using System.Diagnostics.CodeAnalysis;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            // A basic function with a for loop 
            void basic_function(int a)
            {
                for (a = 1; a < 10; a++)
                {
                    Console.WriteLine(a);
                }
            }

            basic_function(10);
            Console.WriteLine("------------");

            // Using recursion
            void basic_function_r(int a)
            {
                if (a <= 1)
                {
                    return;
                }

                Console.WriteLine(a);
                basic_function_r(a - 1);
            }

            basic_function_r(10);

            Console.WriteLine("------------");

            /*** Factorial of a number to demonstrate the concept of recursion

            1. factorial(3) is called first.
            2. factorial(2) is called second.
            3. factorial(1) is called third.
            4. factorial(1) is completed first.
            5. factorial(2) is completed based on the result of factorial(1).
            6. Finally, factorial(3) is completed based on the result of factorial(2).
            ***/
            static int factorial(int b)
            {
                if (b == 1)
                {
                    return 1;
                }
                else
                {
                    return b * factorial(b - 1);
                }
            }

            Console.WriteLine(factorial(3));
            Console.WriteLine("------------");

            /***
             * An algorithm to double elements of an array
             * **
             */

            void double_array(int[] d, int index = 0)
            {
                // Base case: when the index goes past the end of the array
                if (index >= d.Length)
                {
                    return;
                }

                d[index] *= 2;
                double_array(d, index + 1);
            } 
            
            int [] g = { 1, 2, 3, 4 };
            double_array(g);
            Console.WriteLine(string.Join(", ", g));
            Console.WriteLine("------------");
            
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
            Console.WriteLine(recursion_bu(2));
            Console.WriteLine("------------");
            
            /*
             * Sum of array using top-down approach
             */
            int sum_array(int[] a, int index)
            {
                if (index >= a.Length)
                {
                    return 0;
                }
                return a[index] + sum_array(a, index + 1);
            }
            int [] b = { 13, 23, 34, 44 };
            Console.WriteLine(sum_array(b, 0));
            Console.WriteLine("------------");
            
            /*
            * Sum of array using top-down approach
            */
            string reverse_string(string s)
            {
                if (s.Length <= 1)
                {
                    return s;
                }
                return s[s.Length - 1] + reverse_string(s.Substring(0, s.Length - 1));
            }

            string se = "adfdce";
            string reversed = reverse_string(se);
            Console.WriteLine(reversed);
            Console.WriteLine("------------");

            /*
             * Counting the number of x in a string
             */
            
            int counting_x(string s)
            {
                // Base case: empty string
                if (s.Length == 0)
                    return 0;

                // Check first character
                int count = (s[0] == 'x') ? 1 : 0;

                // Recursive call on the rest of the string
                return count + counting_x(s.Substring(1));
            }

            string sd = "axbxxdce";
            int counted = counting_x(sd);
            Console.WriteLine(counted);
            Console.WriteLine("------------");
            
            int printFun(int test)
            {
                if (test < 1)
                     return -1;
                else {
                    Console.Write(test + " ");

                    // statement 2
                    printFun(test - 1);

                    Console.Write(test + " ");
                    return -1;
                }
            }

            // Driver Code
            int test = 3;
            printFun(test);


            //Recursion
            static int Max(int[] array, int index = 0)
            {
                Console.WriteLine("RECURSION");

                // Base case: only one element left
                if (index == array.Length - 1)
                    return array[index];

                // Calculate the max of the remainder and store it in a variable
                int maxOfRemainder = Max(array, index + 1);

                // Compare first number against this variable
                if (array[index] > maxOfRemainder)
                    return array[index];
                else
                    return maxOfRemainder;
            }

            int result = Max(g, 1);
            Console.WriteLine(result);
        }
    }
}