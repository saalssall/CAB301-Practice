namespace SubstringSearch;

public class NaiveSubstringSearch
{
    public int Solve(string text, string pattern)
    {
        int n = text.Length, m = pattern.Length;

        for (int i = 0; i <= n - m; i++)
        {
            int j = 0;
            while (j < m && text[i + j] == pattern[j])
                j++;

            if (j == m) return i; // match found, return index
        }

        return -1; // not found
    }
}