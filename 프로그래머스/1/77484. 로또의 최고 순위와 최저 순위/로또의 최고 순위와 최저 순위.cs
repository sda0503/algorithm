using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int num = 0;
        int zero = 0;
        
        for(int i = 0; i < lottos.Length; i++)
        {
            if(lottos[i] == 0)
            {
                zero++;
                continue;
            }
            if(win_nums.Contains(lottos[i]))
            {
                num++;
            }
            
        }
        
        int[] answer = new int[]{check(num + zero), check(num)};
        return answer;
    }
    
    public int check(int num)
    {
        switch(num)
        {
            case 6:
                return 1;
            case 5:
                return 2;
            case 4:
                return 3;
            case 3:
                return 4;
            case 2:
                return 5;
            default:
                return 6;
        }
    }
}