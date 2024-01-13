using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int i =2;
        int count = n/i;
        int number = 0;
        for(int j=0; j<count; j++){
            number += i * (j + 1);
        }
        return answer = number;
    }
}