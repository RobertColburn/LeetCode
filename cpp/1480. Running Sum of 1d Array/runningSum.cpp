/*
Prompt:
"Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]). Return the running sum of nums."

Constraints:
1 <= nums.length <= 1000
-10^6 <= nums[i] <= 10^6

Robert Colburn
8/1/2023
*/

class Solution {
public:
    vector<int> runningSum(vector<int>& nums) {
        vector<int> numsSum;
        int sum = 0;
        for(int counter = 0; counter < nums.size(); counter++)
        {
            sum += nums[counter];
            numsSum.push_back(sum);
        }
        return numsSum;
    }
};
