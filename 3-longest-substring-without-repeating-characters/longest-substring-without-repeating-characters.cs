public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var set = new HashSet<char>();
        int i = 0, longest = 0;
        for (int j = 0; j < s.Length; ++j) {
            char currentChar = s[j];
            while (set.Contains(currentChar)) {
                set.Remove(s[i++]);
            }
            set.Add(currentChar);
            longest = Math.Max(longest, j - i + 1);
        }
        return longest;
    }
}
