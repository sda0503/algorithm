using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        string j = n.ToString();
        for(int i=0; i<j.Length; i++){
            answer += (int)Char.GetNumericValue(j[i]);
        }
        return answer;
    }
}