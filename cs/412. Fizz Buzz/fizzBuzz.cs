/*
Prompt:
"Given an integer n, return a string array answer (1-indexed) where:
answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
answer[i] == "Fizz" if i is divisible by 3.
answer[i] == "Buzz" if i is divisible by 5.
answer[i] == i (as a string) if none of the above conditions are true."

Constraints:
1 <= n <= 104

Robert Colburn
8/2/2023
*/

public class Solution {
    public IList<string> FizzBuzz(int n) {
        string[] answer = new string[n];

        for(int counter = 1; counter <= n; counter++)
        {
            if(counter % 3 == 0 && counter % 5 == 0)
            answer[counter - 1] = "FizzBuzz";
            else if(counter % 3 == 0)
            answer[counter - 1] = "Fizz";
            else if(counter % 5 == 0)
            answer[counter - 1] = "Buzz";
            else
            answer[counter - 1] = counter.ToString();
        }
        return answer;
    }
}
