public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int index1, index2;
        Dictionary<int, int> complements = new Dictionary<int, int>();
        int[] result = new int[2];
        
        for (int i=0; i<nums.Length; i++) {
            if (!complements.ContainsKey(target - nums[i])) {
                complements.Add(target - nums[i], i);
            }
        }
        
        for (int i=0; i<nums.Length; i++) {
            if (complements.ContainsKey(nums[i]) && complements[nums[i]] != i) {
                result[0] = complements[nums[i]];
                result[1] = i;
            }
        }
        
        return result;
    }
}