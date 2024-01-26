using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
        int count; //약수의 갯수
        
        for (int i = left; i <= right; i++) //left와 right사이의 수
        {
            count = 0; //갯수 초기화
            for (int n = 1; n <= i; n++) // 현재 숫자의 약수 구하기
            {
                if (i % n == 0)
                {
                    count++; //약수 카운트
                }  
            }
            if (count % 2 == 0) //짝수 홀수 확인
                answer += i;
            else
                answer -= i;
        }
        return answer;
    }
}