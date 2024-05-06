public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int[] s = new int[128];
        foreach (char c in jewels) {
            s[c] = 1;
        }
        int ans = 0;
        foreach (char c in stones) {
            ans += s[c];
        }
        return ans;
    }
}
