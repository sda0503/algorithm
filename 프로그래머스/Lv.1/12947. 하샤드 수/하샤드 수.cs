using System;

public class Solution {
    public bool solution(int x) {
        bool answer = true;
        string xx = x.ToString();
        int sum = 0;
        for (int i = 0; i < xx.Length; i++)
        {
            sum += (int)Char.GetNumericValue(xx[i]);
        }
        return answer = x % sum == 0 ? true : false;
    }
}