using System;

public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        char[] str_arr = s.ToCharArray();
        
       for(int i = 0; i < str_arr.Length; ++i)
       {
           if (str_arr[i] == ' ') continue;
           int temp_num = Convert.ToInt32(str_arr[i]) + n;
           if((str_arr[i] >= 'A' && str_arr[i] <= 'Z'))
           {
                if(temp_num > 'Z')
                {
                   temp_num -= 26;
                }
           }
           else
           {
                if(temp_num > 'z')
                {
                    temp_num -= 26;
                }
           }

                str_arr[i] = Convert.ToChar(temp_num);
       }
        answer = new string(str_arr);
        return answer;
    }
}