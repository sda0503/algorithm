using System;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] answer = new int[num_list.Length - n + 1];
        int num = 0;
        for(int i = n - 1; i< num_list.Length; i++)
        {
            answer[num++] = num_list[i];
        }
        return answer;
    }
}