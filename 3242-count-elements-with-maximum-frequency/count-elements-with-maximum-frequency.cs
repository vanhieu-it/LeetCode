public class Solution {
    public int MaxFrequencyElements(int[] nums) {
        int[] counts = new int[101];
        foreach (int num in nums) {
            ++counts[num];
        }
        int answer = 0, max = -1;
        foreach (int count in counts) {
            if (max < count) {
                max = count;
                answer = count;
            } else if (max == count) {
                answer += count;
            }
        }
        return answer;
    }
}
