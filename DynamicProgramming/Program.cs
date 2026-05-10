using static System.Console;

namespace Dynamic_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            new Bottom_Up().Run();
            new Memoization().Run();
            new Top_Down().Run();
            
            var (length, sequence) = LIS.Solve(new[] { 3, 1, 4, 1, 5, 9, 2, 6 });

            WriteLine($"Length:   {length}");
            WriteLine($"Sequence: [{string.Join(", ", sequence)}]");
            WriteLine("------------");
            
            var (lcsLength, lcsSequence) = LCS.Solve("ABCBDAB", "BDCAB");
            WriteLine($"Length:   {lcsLength}");
            WriteLine($"Sequence: {lcsSequence}");
            WriteLine("------------"); 
            
            
            EditDistance editDistance1 = new EditDistance(); 
            WriteLine($"EditDistance: {editDistance1.editDistance("ABCBDAB", "BDCAB")}");
           
            
        }
    }
}
        
       
    
