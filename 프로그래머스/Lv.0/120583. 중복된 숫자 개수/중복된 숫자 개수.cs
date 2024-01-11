using System;

public class Solution {
    public int solution(int[] array, int n) {
        int answer = 0;
        int[] count = Array.FindAll(array, element => element == n);
        
        return answer = count.Length;
    }
}