using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] answers) {
        List<int> answer = new List<int>();
        int[] mem1 = new int[5] {1, 2, 3, 4, 5};
        int[] mem2 = new int[8] {2, 1, 2, 3, 2, 4, 2, 5};
        int[] mem3 = new int[10] {3, 3, 1, 1, 2, 2, 4, 4, 5, 5};
        int[] score= new int[3] {0,0,0};
        
        for(int i=0; i<answers.Length; i++)
        {
            if(answers[i] == mem1[i % mem1.Length]) score[0]++;
            if(answers[i] == mem2[i % mem2.Length]) score[1]++;
            if(answers[i] == mem3[i % mem3.Length]) score[2]++;
        }
        
        int max = 0;
        for(int i=0; i<score.Length; i++)
        {
            if(max < score[i]) max = score[i];
        }
        
        for(int i=0; i<score.Length; i++)
        {
            if(max == score[i]) answer.Add(i+1);
        }
        
        
        return answer.ToArray();
    }
}