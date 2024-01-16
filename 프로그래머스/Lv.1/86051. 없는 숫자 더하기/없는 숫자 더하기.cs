using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        for(int i=0; i<10; i++)
        {
            int xx = Array.Find(numbers, element => element == i);
            answer+=xx;
        }
        answer = 45 - answer;
        return answer;
    }
}