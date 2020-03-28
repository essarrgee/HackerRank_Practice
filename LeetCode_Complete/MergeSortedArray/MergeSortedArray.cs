public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int[] nums1Copy = (int[]) nums1.Clone();
        int p1 = 0;
        int p2 = 0;
        while (p1 < m || p2 < n) {
            int nums1pt = Int32.MaxValue;
            if (p1 < m) {
                nums1pt = nums1Copy[p1];
            }
            int nums2pt = Int32.MaxValue;
            if (p2 < n) {
                nums2pt = nums2[p2];
            }
            if (nums1pt <= nums2pt) {
                nums1[p1+p2] = nums1Copy[p1];
                p1++;
            }
            else {
                nums1[p1+p2] = nums2[p2];
                p2++;
            }
        }
    }
}