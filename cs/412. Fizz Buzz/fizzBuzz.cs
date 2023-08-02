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
