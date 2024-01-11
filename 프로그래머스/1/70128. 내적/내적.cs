using System;

public class Solution {
    public int solution(int[] a, int[] b) {
        int answer;
        int count = 0;
        for(int i=0; i< a.Length; i++){
            count += a[i] * b[i];
        }
        return answer = count;
    }
}