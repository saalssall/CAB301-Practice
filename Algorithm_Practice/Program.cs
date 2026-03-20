using System;

namespace Algorithm_Practice
{
    class Program
    {
        static void Main(string[] args)
        { 
            /*** Practicing for week1 content
            1. Checking whether a number in an array is even or odd
            2. Finding the minimum value in an array
            3. Finding the maximum value in an array
            4. Bubble sort (sorting elements in an array from lowest to highest)
            5. Minimum distance
            

            Input: Array of A[0...n-1] numbers
            Output: for each number, print whether it is even or odd
            
            Steps:
            for an Array of size n 
                if number is even:
                    print(number is even)
                else if number is odd:
                    print(number is odd) 
                    
            Pseudocode:
            for i <- 0 to n-1 do
                if A[0] mod 2 = 0 then
                    print A[i], "is even"
                else 
                    print A[i], "is odd"
                end if
            end for
            ***/
                    
        void checkNum(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is an even number."); 
            }
            else if (num % 2 != 0)
            {
                Console.WriteLine($"{num} is an odd number.");
            }
        }
        //Checking the output
        checkNum(100);
        checkNum(205);
        checkNum(234);
        checkNum(633);
        checkNum(237);
        checkNum(546);
        checkNum(135); 
        
        Console.WriteLine("------------");    
        //A second method
        void checkNumber(int num1)
        {
            Console.WriteLine($"{num1} is {(num1 % 2 == 0 ? "an even number." : "an odd number.")}");
        }
        //Checking the output of the algorithm
        checkNumber(13);
        checkNumber(102);
        checkNumber(112);
        checkNumber(2445);
        checkNumber(53221);
        
        /*** 2. Find the lowest value in an array
        Input: a few numbers from the array
        Output: the lowest value in the array
        
        Steps: 
        1. Go through the elements in the array one by one
        2. Check if the value is the lowest so far
            //If yes, save it
            //else move on
        3. Print the lowest value 
        
        Pseudocode: 
       min <- A[0]
       for i <- 0 to n-1 do
           if A[i] < min then
               min > A[i]
           end if
       end for
       return min
        ***/
        Console.WriteLine("------------");  
        int[] numbers = { 123, 34, 54, 23, 52, 155, 84, 78 };
        int minValue = numbers[0];
        
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < minValue)
            {
                minValue = numbers[i];
            }
        }
        
        Console.WriteLine($"The minimum value is: {minValue}!");
        
        /*** 3. Find the maximum value in an array
        Input: a few numbers from the array
        Output: the maximum value in the array

        Steps:
        1. Go through the elements in the array one by one
        2. Check if the value is the maximum so far
            //If yes, save it
            //else move on
        3. Print the maximum value

        Pseudocode:
       max <- A[0]
       for i <- 0 to n-1 do
           if A[i] > max then
               max < A[i]
           end if
       end for
       return max
        ***/
        Console.WriteLine("------------");  
        int [] newNumbers = {32, 34, 2, 455, 622, 124, 786, 22};
        int maxValue = newNumbers[0];

        for (int i = 0; i < newNumbers.Length; i++)
        {
            if (newNumbers[i] > maxValue)
            {
                maxValue = newNumbers[i];
            }
        }
        
        Console.WriteLine($"The maximum value is: {maxValue}!");
        
        /*** 4. Bubble sort (sorting elements in an array from lowest to highest)
        Input: numbers from the array
        Output: sorted array from lowest to highest

        Steps:
        1. Go through the elements in the array one by one
        2. For each value, compare it with the next value
            //If the value is higher, swap the values so that the higher value comes last
        3. Go through all the elements in the array 
        4. Print the sorted array

        Pseudocode:
       bubbleSort(A, n)
           
           for i ← 0 to n - 2 do
               swapped ← false
           
               for j ← 0 to n - i - 2 do
                   if A[j] > A[j + 1] then
                       swap A[j] and A[j + 1]
                       swapped ← true
                   end if
               end for
               if swapped = false then
                   break
               end if
           end for
           
           return A
        ***/
        
        Console.WriteLine("------------");
        
        int[] sortArray = { 12, 43, 44, 3, 11, 49 };
        int n = sortArray.Length;
        
        for (int i = 0; i < n - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (sortArray[j] > sortArray[j + 1])
                {
                    int temp = sortArray[j];
                    sortArray[j] = sortArray[j + 1];
                    sortArray[j + 1] = temp;
                    swapped = true;
                }
            }

            if (!swapped)
            {
                break;
            }
        }
        
        Console.WriteLine("Sorted array: " + string.Join(", ", sortArray));
        
        /*** 5. Minimum distance (finding the minimum distance between two points)
        Input: Array A[0...n-1] of numbers   
        Output: minimum distance between two elements

        Steps:
        1. Go through the elements in the array one by one
        2. For each value, compare it with the next value
            //If the value is higher, swap the values so that the higher value comes last
        3. Go through all the elements in the array
        4. Print the sorted array

        Pseudocode:
       minDistance(A, n)
            dmin ← infinity
               for i ← 0 to n - 2 do
                   for j ← i + 1 to n -1 do
                        if |A[i] - A[j]| < dmin then
                            dmin ← |A[i] - A[j]|
                        end if 
                    end for
                end for
            return dmin
        ***/
        
        Console.WriteLine("------------");

       

        static int minDistance(int[] values)
        {
            int dmin = int.MaxValue;

            for (int i = 0; i < values.Length - 1; i++)
            {
                for (int j = i + 1; j < values.Length; j++)
                {
                    int diff = Math.Abs(values[i] - values[j]);

                    if (diff < dmin)
                        dmin = diff;
                }
            }

            return dmin;
        }
        int[] numbers1 = { 30, 40, 1, 90, 60, 50, 10 };
        int results = minDistance(numbers1);
        Console.WriteLine("The minimum distance is: {0:d}", results);
        Console.Write("\nPress any key to continue . . . ");
        Console.ReadKey();

        }
    }
}




