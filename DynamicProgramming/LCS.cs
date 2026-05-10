namespace Dynamic_Programming;

public class LCS
{
    public static (int Length, string Sequence) Solve(string a, string b)
    {
        int m = a.Length, n = b.Length;
        var dp = new int[m + 1, n + 1];

        for (int i = 1; i <= m; i++)
        for (int j = 1; j <= n; j++)
            dp[i, j] = a[i-1] == b[j-1]
                ? dp[i-1, j-1] + 1
                : Math.Max(dp[i-1, j], dp[i, j-1]);

        return (dp[m, n], Reconstruct(dp, a, b, m, n));
    }

    private static string Reconstruct(int[,] dp, string a, string b, int i, int j)
    {
        if (i == 0 || j == 0) return "";
        if (a[i-1] == b[j-1]) return Reconstruct(dp, a, b, i-1, j-1) + a[i-1];

        return dp[i-1, j] >= dp[i, j-1]
            ? Reconstruct(dp, a, b, i-1, j)
            : Reconstruct(dp, a, b, i, j-1);
    }
}