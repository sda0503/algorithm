using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        for(int i=0; i<s.Length; i++)
        {
            int index = -1;
            for(int j = i - 1; j >= 0; j--)
            {
                if(s[i] == s[j])
                {
                    index = i - j;
                    break;
                }
            }
            answer[i] = index;
        }
        return answer;
    }
}