public class Solution {
    public int MaxSubarrayLength(int[] nums, int k) {
        var count = new Dictionary<int, int>();
        int longest = 0;
        for (int i = 0, j = 0; i < nums.Length; ++i) {
            if (count.ContainsKey(nums[i])) {
                count[nums[i]] += 1;
            } else {
                count[nums[i]] = 1;
            }
            while (count[nums[i]] > k) {
                count[nums[j]] -= 1;
                j++;
            }
            longest = Math.Max(longest, i - j + 1);
        }
        return longest;
    }
}
