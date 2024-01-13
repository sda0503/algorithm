public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        if (a < b)
        {
            for (var i = a; i <= b; i++)
            {
                answer += i;
            }
        }
        else
        {
            for (var i = b; i <= a; i++)
            {
                answer += i;
            }
        }
        if (a == b) answer = a;
        
        return answer;
    }
}