using System;

public class Solution {
    public int solution(int num1, int num2) {
        int answer = 0;
        float temp = 0;
        float temp2 = 0;
        if(num1>0 && num1<=100 && num2>0 && num2<=100)
        {
            temp= (float)num1/(float)num2;
            temp2= temp*1000;
            answer = (int)temp2;
        }
        return answer;
    }
}