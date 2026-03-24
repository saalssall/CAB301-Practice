// Practicing the concept of recursion
using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            // A basic function with a for loop 
            // void basic_function(int a)
            // {
            //     for (a = 1; a < 10; a++)
            //     {
            //         Console.WriteLine(a);
            //     }
            // }
            // basic_function(10);
            
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
            
            
            
        }
    }
}