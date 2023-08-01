/*

*/

public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int maxWealth = accounts[0][0];
        int wealth;

        for(int customer = 0; customer < accounts.Length; customer++)
        {
            wealth = 0;
            for(int bank = 0; bank < accounts[customer].Length; bank++)
            {
                wealth += accounts[customer][bank];
            }
            if(wealth > maxWealth)
            maxWealth = wealth;
        }
        return maxWealth;
    }
}
