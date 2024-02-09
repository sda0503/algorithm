using System;

public class Solution {
    public int[] solution(int start_num, int end_num) {
        int count = end_num - start_num;
        int[] answer = new int[count + 1];
        for(int i = start_num; i<=end_num; i++)
        {
            answer[i - start_num] = i;
        }
        return answer;
    }
}