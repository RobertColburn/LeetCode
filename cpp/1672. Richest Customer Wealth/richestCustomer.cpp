/*
Prompt:
"You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank. Return the wealth that the richest customer has.
A customer's wealth is the amount of money they have in all their bank accounts. The richest customer is the customer that has the maximum wealth."

Constraints:
m == accounts.length
n == accounts[i].length
1 <= m, n <= 50
1 <= accounts[i][j] <= 100

Robert Colburn
8/1/2023
*/

class Solution {
public:
    int maximumWealth(vector<vector<int>>& accounts) {
        int maxWealth = accounts[0][0];
        int wealth;
        for(int customer = 0; customer < accounts.size(); customer++)
        {
            wealth = 0;
            for(int bank = 0; bank < accounts[customer].size(); bank++)
            {
                wealth += accounts[customer][bank];
            }
            if(wealth > maxWealth)
            maxWealth = wealth;
        }
        return maxWealth;
    }
};
