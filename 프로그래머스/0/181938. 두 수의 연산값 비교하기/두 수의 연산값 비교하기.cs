using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        string aStr = a.ToString() + b.ToString();
        
        return answer = Convert.ToInt32(aStr) > 2*a*b ? Convert.ToInt32(aStr) : 2*a*b;
    }
}