namespace Dynamic_Programming;

public class Top_Down
{
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

    public void Run()
    {
        string se = "adfdce";
        string reversed = reverse_string(se);
        Console.WriteLine(reversed);
        Console.WriteLine("------------");
    }
}