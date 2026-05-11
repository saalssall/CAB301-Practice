namespace SubstringSearch;

public class BoyerMooreAlgorithm
{
    // Returns index of first occurrence of p in t, or -1 if not found
    public static int Search(string p, string t)
    {
        int m = p.Length, n = t.Length;
        var badChar    = BuildBadChar(p);
        var goodSuffix = BuildGoodSuffix(p);

        int i = 0;
        while (i <= n - m)
        {
            int j = m - 1;
            while (j >= 0 && p[j] == t[i + j]) j--;

            if (j < 0) return i;

            i += Math.Max(j - badChar(t[i + j]), goodSuffix[j]);
        }

        return -1;
    }

    // Last occurrence of each character in the pattern — O(m)
    private static Func<char, int> BuildBadChar(string p)
    {
        var table = new Dictionary<char, int>();
        for (int i = 0; i < p.Length; i++) table[p[i]] = i;
        return c => table.ContainsKey(c) ? table[c] : -1;
    }

    // How far to shift when a suffix matches then fails — O(m)
    private static int[] BuildGoodSuffix(string p)
    {
        int m      = p.Length;
        var shift  = new int[m];
        var border = new int[m + 1];

        // Phase 1 — compute border positions right to left
        int i = m, j = m + 1;
        border[i] = j;
        while (i > 0)
        {
            while (j <= m && p[i - 1] != p[j - 1])
            {
                if (shift[j - 1] == 0) shift[j - 1] = j - i;
                j = border[j];
            }
            border[--i] = --j;
        }

        // Phase 2 — fill remaining using border[0], start from i=1 to avoid i-1 = -1
        j = border[0];
        for (i = 1; i <= m; i++)
        {
            if (shift[i - 1] == 0) shift[i - 1] = j;
            if (i == j) j = border[j];
        }

        return shift;
    }
}