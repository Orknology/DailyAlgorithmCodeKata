using System;
public class Solution {
    public long solution(long n) {
        long answer = 0;
        double sqrt = Math.Sqrt(n);
        if(sqrt % 1 == 0)
            answer = ((long)sqrt + 1)*((long)sqrt +1);    
        else
            answer = -1;
        return answer;
    }
}