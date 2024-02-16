using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(string binomial) {
        List<string> list = new List<string>();
        int answer = 0;
        if(binomial.Contains("+"))
           {
               list= binomial.Split("+").ToList(); 
               answer = Convert.ToInt32(list[0]) + Convert.ToInt32(list[1]);
           }
           
        else if (binomial.Contains("-"))
           {
               list= binomial.Split("-").ToList();
                answer = Convert.ToInt32(list[0]) - Convert.ToInt32(list[1]);
           }
        else if(binomial.Contains("*"))
        {
            list= binomial.Split("*").ToList();
            answer = Convert.ToInt32(list[0]) * Convert.ToInt32(list[1]);
        }
        
        return answer;
    }
}