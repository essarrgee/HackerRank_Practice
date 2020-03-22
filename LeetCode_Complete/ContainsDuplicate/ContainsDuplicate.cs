public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> frequency = new HashSet<int>();
        for (int i=0; i<nums.Length; i++) {
            if (frequency.Contains(nums[i])) {
                return true;
            }
            else {
                frequency.Add(nums[i]);
            }
        }
        
        return false;
    }
}