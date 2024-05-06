public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int left = 0, right = nums.Length;
        while (left < right) {
            int mid = (left + right) / 2;
            if (nums[mid] >= target) {
                right = mid;
            } else {
                left = mid + 1;
            }
        }
        return left;
    }
}
