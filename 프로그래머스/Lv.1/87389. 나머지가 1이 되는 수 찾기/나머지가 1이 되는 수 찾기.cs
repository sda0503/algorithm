using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        bool check = false;
        int x = 0;
        while(!check){
            x++;
            if(n % x == 1){
                answer = x;
                check = true;
            }
        }
        
        return answer;
    }
}