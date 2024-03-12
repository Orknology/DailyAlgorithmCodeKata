using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        // 1부터 number까지, 기사번호의 약수 개수만큼 공격력을 가진 무기 구매
        // 공격력 제한을 넘는 기사는 고정 공격력 무기 구매, 무기 공격력당 1kg 철 소모
        // 무기를 전부 만들기 위해 필요한 철의 무게 리턴
        
        //배열로 기사단원의 수를 선언하고
        //우선 각 기사단원마다 약수의 갯수를
        //이후 그것이 제한수치를 넘는지 판단 
        
        int answer = 0;
        int[] cnt = new int[number + 1];
        
        //약수 구하는 이중 포문은 인터넷에서 참조...
        for(int i = 1; i <= number; i++)
        {
            for(int j = i; j <= number; j += i)
            {
                cnt[j]++;
            }
        }
        
        //cnt[i]를 공격력 제한수치와 비교
        for(int i = 1; i <= number; i++)
        {
            if(cnt[i] > limit)
                answer += power;
            else
                answer += cnt[i];
        }
        
        return answer;
    }
}