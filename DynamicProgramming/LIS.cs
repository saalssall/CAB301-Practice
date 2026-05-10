namespace Dynamic_Programming;


public class LIS
{
    public static (int Length, List<int> Sequence) Solve(int[] arr)
    {
        int n = arr.Length;
        var dp = new int[n]; // dp[i] = LIS length ending at i
        var parent = new int[n]; // for sequence reconstruction

        Array.Fill(dp, 1);
        Array.Fill(parent, -1);

        for (int i = 1; i < n; i++)
        for (int j = 0; j < i; j++)
            if (arr[j] < arr[i] && dp[j] + 1 > dp[i])
            {
                dp[i] = dp[j] + 1;
                parent[i] = j;
            }

        int best = Array.IndexOf(dp, dp.Max());
        return (dp[best], BuildSequence(arr, parent, best));
    }

    private static List<int> BuildSequence(int[] arr, int[] parent, int i)
    {
        if (i == -1) return new List<int>();
        var seq = BuildSequence(arr, parent, parent[i]);
        seq.Add(arr[i]);
        return seq;
    }
}