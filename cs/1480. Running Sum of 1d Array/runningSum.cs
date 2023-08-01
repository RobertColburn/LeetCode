/*

*/

public class Solution {
    public int[] RunningSum(int[] nums) {
        int sum = 0;
        int[] numsSum = new int[nums.Length];
        for(int counter = 0; counter < nums.Length; counter++)
        {
            sum += nums[counter];
            numsSum[counter] = sum;
        }
        return numsSum;
    }
}
