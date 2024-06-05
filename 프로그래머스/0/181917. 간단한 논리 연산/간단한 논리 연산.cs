using System;

public class Solution {
    public bool solution(bool x1, bool x2, bool x3, bool x4) {
        bool answer = true;
        
        return answer = TFA(TFV(x1,x2),TFV(x3,x4));
    }
    public bool TFV(bool x1, bool x2){
        if(!x1 && !x2){
            return false;    
        }else{
            return true;
        }
    }
    public bool TFA(bool x1, bool x2){
        if(x1 && x2){
            return true;    
        }else{
            return false;
        }
    }
}