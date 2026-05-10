namespace Dynamic_Programming;

public class EditDistance
{
    public int editDistance(string u, string v)
    {
        var cache = new Dictionary<(string, string), int>();
        int editDistR(string s, string t) {
            if (cache.ContainsKey((s, t))) { return cache[(s, t)]; }
            if (s.Length == 0) { return t.Length; } // insert all
            if (t.Length == 0) { return s.Length; } // delete all
            if (s[0] == t[0]) { // First character correct
                return cache[(s,t)] = editDistR(s[1..], t[1..]);
            }
            int sC = editDistR(s[1..], t[1..]); // substitute
            int iC = editDistR(s, t[1..]); // insert
            int dC = editDistR(s[1..], t); // delete
            return cache[(s, t)] = new[] { iC, sC, dC }.Min() + 1;
        }
        return editDistR(u, v);
    }
}