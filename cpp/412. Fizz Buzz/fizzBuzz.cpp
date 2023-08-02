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

class Solution {
public:
    vector<string> fizzBuzz(int n) {
        vector<string> answer;
        for(int counter = 1; counter <= n; counter++)
        {
            if(counter % 3 == 0 && counter % 5 == 0)
            answer.push_back("FizzBuzz");
            else if(counter % 3 == 0)
            answer.push_back("Fizz");
            else if(counter % 5 == 0)
            answer.push_back("Buzz");
            else
            answer.push_back(to_string(counter));
        }
        return answer;
    }
};
