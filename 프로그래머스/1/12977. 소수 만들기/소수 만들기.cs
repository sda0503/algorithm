using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;

        for(int i =0; i<nums.Length; i++)
        {
            for(int j=i+1; j< nums.Length -1 ; j++)
            {
                for(int k=j+1; k<nums.Length; ++k)
                {
                    int sum = nums[i] + nums[j] + nums[k];
                    if(CheckDecimal(sum)) answer++;
                }
            }
        }

        return answer;
    }
    
    bool CheckDecimal(int num)
    {
        int check_num = num / 2;
        for(int i=2; i<check_num; i++)
        {
            if(num % i == 0) return false;
        }
        return true;
    }
}