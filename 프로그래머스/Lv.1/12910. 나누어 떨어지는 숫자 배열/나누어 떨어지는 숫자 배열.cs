using System;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int[] answer = new int[arr.Length];
        int cnt = 0;
        for(int i=0; i< arr.Length; i++)
        {
            if(arr[i] % divisor == 0)
            {
                answer[cnt]= arr[i];
                cnt++;
            }
        }
        if(cnt == 0)
        {
            Array.Resize(ref answer, 1);
            answer[cnt] = -1;
        }
        else
        {
            Array.Resize(ref answer, cnt);
            Array.Sort(answer);
        }
        
        return answer;
    }
}