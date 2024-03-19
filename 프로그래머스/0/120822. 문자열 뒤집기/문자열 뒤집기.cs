using System;
using System.Linq;

public class Solution {
    public string solution(string my_string) {
        char[] charArr = my_string.ToArray();
        Array.Reverse(charArr);
        string answer = new string(charArr);
        
        return answer;
    }
}