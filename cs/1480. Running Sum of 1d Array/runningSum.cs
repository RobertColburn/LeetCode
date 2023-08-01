/*
Prompt:
"Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]). Return the running sum of nums."

Constraints:
1 <= nums.length <= 1000
-10^6 <= nums[i] <= 10^6

Robert Colburn
8/1/2023
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
