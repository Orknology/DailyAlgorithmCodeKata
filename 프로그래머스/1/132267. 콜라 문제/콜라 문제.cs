//콜라의 빈병이 소진될 때 까지니까 for문 대신 while문
//n을 a로 나누기 = 받을 횟수 이기에 n/a*b
//위 계산 이후 남은 빈 병의 갯수 계산 필요
using System;

public class Solution {
    public int solution(int a/*줘야하는 양*/, int b/*받을 양*/, int n/*남은 양*/) {
        int answer = 0;
        
        while(n > a - 1) // a보다 적어질 때 까지 교환
        {
            answer += (n / a) * b;
            n = (n / a) * b + n % a;
        }
        
        return answer;
    }
}