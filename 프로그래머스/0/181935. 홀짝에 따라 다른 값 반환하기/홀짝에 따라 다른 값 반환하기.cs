using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        bool check = n % 2 == 0 ? true : false;
        for(int i=0; i<=n; i++)
        {
            if(check)
            {
                if(i % 2 == 0)
                {
                    answer += i * i;
                }
            }
            else
            {
                if(i % 2 == 1)
                {
                    answer += i;
                }
            }
        }
        return answer;
    }
}