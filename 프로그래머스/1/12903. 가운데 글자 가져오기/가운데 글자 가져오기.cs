public class Solution {
    public string solution(string s) {
        string answer = "";
        
        for(int i=0; i<s.Length; i++){
            if(s.Length % 2 == 1){
                answer = s[s.Length / 2].ToString();
            }else{
                answer = s[s.Length / 2 - 1].ToString() + s[s.Length / 2].ToString();
            }
        }
        return answer;
    }
}