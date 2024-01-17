using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        char[] x = n.ToString().ToCharArray();
        
        Array.Sort(x);
        Array.Reverse(x);
        return answer = Convert.ToInt64(new string(x));
    }
}