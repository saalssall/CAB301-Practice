using System;

namespace Searching_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Binary Search
            Binary_Search biSearch = new Binary_Search();
            
            int [] array4Binary = new []{ 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int [] arrayLS = new []{ 21, 2, 3, 43, 5, 61, 7, 8, 9 };
            int searchingValue = 3;
            
            //Binary Search
            int res = biSearch.binary_search(array4Binary, searchingValue);
            string message = res != -1
                ? $"Found at index {res}"
                : "Value not found.";
            Console.WriteLine(message);
             
            Console.WriteLine("------------");
            //Linear Search
            Linear_SearchAlgorithm linearSearch = new Linear_SearchAlgorithm();

            //Linear Search
            int searchValue = 43;
            int resLinearSearchS = linearSearch.Linear_Search(arrayLS, searchValue);
            string message1 = resLinearSearchS != -1
                ? $"Found at index {resLinearSearchS}"
                : "Value not found.";
            Console.WriteLine(message1);

        }
    }
}

