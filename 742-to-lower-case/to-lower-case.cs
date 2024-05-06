public class Solution {
    public string ToLowerCase(string s) {
        char[] cs = s.ToCharArray();
        for (int i = 0; i < cs.Length; ++i) {
            if (cs[i] >= 'A' && cs[i] <= 'Z') {
                cs[i] = (char)(cs[i] | 32);
            }
        }
        return new string(cs);
    }
}
