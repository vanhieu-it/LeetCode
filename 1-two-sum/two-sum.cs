using System;
using System.Collections.Generic;

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++) {
            int x = nums[i];
            int y = target - x;
            if (map.ContainsKey(y)) {
                return new int[] { map[y], i };
            }
            map[x] = i;
        }
        
        throw new ArgumentException("No two sum solution");
    }
}
