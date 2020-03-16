public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] productList = new int[nums.Length];
        int totalProduct = 1;
        int ignoreOneZeroTotalProduct = 1;
        bool ignoredOneZero = false;
        for (int i=0; i<nums.Length; i++) {
            totalProduct *= nums[i];
            if (nums[i] != 0 || ignoredOneZero) {
                ignoreOneZeroTotalProduct *= nums[i];
            }
            else {
                ignoredOneZero = true;
            }
        }
        for (int i=0; i<nums.Length; i++) {
            if (nums[i] != 0) {
                productList[i] = totalProduct/nums[i];
            }
            else {
                productList[i] = ignoreOneZeroTotalProduct;
            }
        }
        
        return productList;
    }
}