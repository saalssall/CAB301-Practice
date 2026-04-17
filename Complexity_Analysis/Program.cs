using System;

namespace Complexity_Analysis
{
    class Program
    {
        static void Main(string[] args)
        {
            void PrintArray(int[] A)
            {
                Console.Write("[");
                Console.Write(A[0]);

                for (int i = 1; i < A.Length; i++)
                {
                    Console.Write(", " + A[i]);
                }
                Console.Write("]");
                Console.WriteLine();
            }
            
            //Cocktail search
            CocktailShakerSortAlgorithm cocktailsort = new CocktailShakerSortAlgorithm();
            int[] array = [1, 6, 2, 5, 2, 5, 3];
            Console.WriteLine("Sorted before:");
            PrintArray(array);
            Console.WriteLine("Sorted after:");
            cocktailsort.CocktailShakerSort(array);
            PrintArray(array);
            
            //Jump-search
            JumpSearchAlgorithm jumpSearchAlgorithm = new JumpSearchAlgorithm();
            int[] array1 = [1, 2, 3, 4, 5, 6, 7];
            Console.WriteLine("Search result index: " + jumpSearchAlgorithm.JumpSearch(array1, 3));
            
            
            
            
            

            
            
        }
    }
}
