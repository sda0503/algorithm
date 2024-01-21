using System;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;
        int w = 0;
        int h = 0;
        for(int i=0; i< sizes.GetLength(0); i++)
        {
            int width = sizes[i, 0];
            int height = sizes[i, 1];
            
            if(height > width)
            {
                width = sizes[i,1];
                height = sizes[i,0];
            }
            if(height > h)
            {
                h = height;
            }
            if(width > w)
            {
                w = width;
            }
        }
        answer = w * h;
        return answer;
    }
}