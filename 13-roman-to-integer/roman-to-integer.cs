using System;
using System.Collections.Generic;

public class Solution {
    public int RomanToInt(string s) {
        string cs = "IVXLCDM";
        int[] vs = {1, 5, 10, 50, 100, 500, 1000};
        Dictionary<char, int> d = new Dictionary<char, int>();
        for (int i = 0; i < vs.Length; ++i) {
            d.Add(cs[i], vs[i]);
        }
        int n = s.Length;
        int ans = d[s[n - 1]];
        for (int i = 0; i < n - 1; ++i) {
            int sign = d[s[i]] < d[s[i + 1]] ? -1 : 1;
            ans += sign * d[s[i]];
        }
        return ans;
    }
}
