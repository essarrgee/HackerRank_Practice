public class Solution {
    public int getArea(int[] height, int index1, int index2) {
        return (Math.Abs(index2-index1) * Math.Min(height[index1],height[index2]));
    }
    
    public int MaxArea(int[] height) {
        int index1 = 0;
        int index2 = height.Length-1;
        int maxArea = 0;
        while (index1 < index2) {
            int currentArea = getArea(height, index1, index2);
            if (currentArea > maxArea) {
                maxArea = currentArea;
            }
            if (height[index1] < height[index2]) {
                index1++;
            }
            else {
                index2--;
            }
        }
        
        return maxArea;
    }
}