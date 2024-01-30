using System;

public class Solution {
    public int solution(int[] num_list, int n) {
        int answer = 0;
        int x = Array.IndexOf(num_list , n);
        return answer = x != -1 ? 1 : 0;
    }
}