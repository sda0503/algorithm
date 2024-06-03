using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = num_list;

        int lastIdx = num_list.Length - 1;

        int[] num = new int[] { num_list[lastIdx - 1] < num_list[lastIdx] ? num_list[lastIdx] - num_list[lastIdx - 1] : num_list[lastIdx] * 2 };
        
        return answer.Concat(num).ToArray();
    }
}