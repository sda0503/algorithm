using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        int product =1;
        int square=0;
        for(int i=0; i< num_list.Length; i++)
        {
            product *= num_list[i];
            square += num_list[i];
        }
        square = square*square;
        return answer = product < square ? 1 : 0;
    }
}